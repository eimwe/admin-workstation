using admin_workstation.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_workstation.Repositories
{
    public class ClassroomRepository
    {
        private readonly string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=lang-center;Integrated Security=True;Trust Server Certificate=True";

        public List<Classroom> GetClassrooms()
        {
            var classrooms = new List<Classroom>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM classrooms ORDER BY id DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Classroom classroom = new Classroom();
                                classroom.id = reader.GetInt32(0);
                                classroom.room = reader.GetString(1);

                                classrooms.Add(classroom);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return classrooms;
        }
    }
}
