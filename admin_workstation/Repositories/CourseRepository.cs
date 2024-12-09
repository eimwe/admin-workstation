using admin_workstation.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_workstation.Repositories
{
    public class CourseRepository
    {
        private readonly string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=lang-center;Integrated Security=True;Trust Server Certificate=True";

        public List<Course> GetCourses()
        {
            var courses = new List<Course>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM courses ORDER BY id DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
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
