using admin_workstation.Configs;
using admin_workstation.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_workstation.Repositories
{
    public class ClassroomRepository
    {
        private readonly string connectionString = DatabaseConfig.GetConnectionString();
        
        public List<Classroom> GetClassrooms()
        {
            var classrooms = new List<Classroom>();

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM classrooms ORDER BY id DESC";
                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        using (var reader = command.ExecuteReader())
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
