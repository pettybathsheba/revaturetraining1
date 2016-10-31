using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterApp.DataAccess.models;

namespace MonsterApp.DataAccess
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AdoData
    {
        
        public bool InsertGender(models.Gender genders)
        {
            var n = new SqlParameter("name", genders.GenderName);
            var query = "insert into Monster.Gender(GenderName, Active) values (@name, 1)";

            return InsertData(query, n) == 1;

        }

        public bool InsertMonster(models.Monster monster)
        {
            var n = new SqlParameter("name", monster.Name);
            var query = "insert into Monster.Monster(Name, TypeId, Active) values (@name,1, 1)";

            return InsertData(query, n) == 1;

        }




        private int InsertData(string query, params SqlParameter[] parameters)
        {
            int result;

            using (var connection = new SqlConnection(connectionstring))
            {
                var cmd = new SqlCommand(query, connection);

                connection.Open();
                cmd.Parameters.AddRange(parameters);
                result = cmd.ExecuteNonQuery();
            }

            return result;
        }
    }
}