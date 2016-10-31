using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterApp.DataAccess.models;
/// <summary>
///  var active = new SqlParameter("active", gender.Active); needs to be converted because the bit wont transfer well
/// </summary>
namespace MonsterApp.DataAccess
{
    public partial class AdoData
    {
        public bool UpdateGender(Gender gender)
        {
            var query = "update Monster.Gender set name = @name, Active = @active where GenderId = @id";
            var name = new SqlParameter("name", gender.GenderName);
            var active = new SqlParameter("active", gender.Active ? 1 : 0);
            var id = new SqlParameter("id", gender.GenderId);
            int result;
            using (var connection = new SqlConnection(connectionstring))
            {

                var cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.Parameters.AddRange(new SqlParameter[] { name, active, id });

                result = cmd.ExecuteNonQuery();

           }
            return result > 0;
        }
    }
}
