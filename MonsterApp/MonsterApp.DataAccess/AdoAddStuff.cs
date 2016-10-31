using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterApp.DataAccess.models;

namespace MonsterApp.DataAccess
{
    public partial class AdoData
    {
        //public bool InsertGender(Gender gender)
        //{
        //    var name = new SqlParameter("name", gender.GenderName);
        //    var query = "insert into Monster.Gender(GenderName, Active) values (@name, 1)";
        //    var n1 = new SqlParameter("name", gender.GenderName);
        //    var n2 = new SqlParameter("name", gender.GenderName);
        //    var n3 = new SqlParameter("name", gender.GenderName);
        //}

        //public bool Inserttitle(MonsterTitle title)
        //{
        //    var query = "insert into Monster.MonsterTitle(Title, Active) values (@name, 1)";
        //    var n1 = new SqlParameter("name", title.);
        //    var n2 = new SqlParameter("name", gender.GenderName);
        //}

        //public bool InsertGender(MonsterType type)

        //{

        //    var query = "insert into Monster.MonSterType(TypeName, Active) values (@name, 1)";
        //}

        private int InsertData(String query, params SqlParameter[] parameters);
        {
        int result;

        using (var connection = new SqlConnection(connectionString))
            {
            var cmd = new SqlCommand(query, connection);
             connection.Open();
                
        cmd.Parameters.AddRange(parameters);
        result = cmd.ExecuteNonQuery();

        }
return IAsyncResult;
}
}
