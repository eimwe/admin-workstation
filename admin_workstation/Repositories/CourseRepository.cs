using admin_workstation.Configs;
using admin_workstation.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_workstation.Repositories
{
    public class CourseRepository
    {
        private readonly string connectionString = DatabaseConfig.GetConnectionString();

        public List<Course> GetCourses()
        {
            var courses = new List<Course>();

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM courses ORDER BY id DESC";
                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Course course = new Course();
                                course.id = reader.GetInt32(0);
                                course.title = reader.GetString(1);
                                course.about = reader.GetString(2);
                                course.duration = reader.GetInt32(3);
                                course.totalprice = reader.GetInt32(4);
                                course.monthprice = reader.GetInt32(5);

                                courses.Add(course);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return courses;
        }
    }
}
