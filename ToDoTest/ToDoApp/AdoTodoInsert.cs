using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp
{
    class AdoTodoInsert
    {
        private String connectionstring = ConfigurationManager.ConnectionStrings["ToDoEntities3"].ConnectionString;

        public bool InsertTodo(Models.TodoTableModel item)
        {
            var n = new SqlParameter("item", TodoTableModel.Tasktodo);
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

