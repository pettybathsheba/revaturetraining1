using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterApp.DataAccess.models;

namespace MonsterApp.DataAccess
{
    public partial class AdoData
    {
        private String connectionstring = ConfigurationManager.ConnectionStrings["MonsterDB"].ConnectionString;

        public List<models.Gender> GetGenders()
        {
            try
            {
                var ds = GetDataDisconnected("select * from Monster.Gender;");
                var genders = new List<models.Gender>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    genders.Add(new models.Gender()
                    {
                        Genderid = int.Parse(row[0].ToString()),
                        GenderName = row[1].ToString(),
                        Active = bool.Parse(row[2].ToString())
                    });
                }

                return genders;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<MonsterType> GetMonsterTypes()
        {
            throw new NotImplementedException("todo");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Title> GetTitles()
        {
            throw new NotImplementedException("todo");
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private DataSet GetDataDisconnected(string query)
        {
            SqlDataAdapter da;
            DataSet ds;
            SqlCommand cmd;

            using (var connection = new SqlConnection(connectionstring))
            {
                cmd = new SqlCommand(query, connection);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();

                da.Fill(ds);
            }

            return ds;

        }
    }
}

    