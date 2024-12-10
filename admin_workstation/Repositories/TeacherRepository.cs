using admin_workstation.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_workstation.Repositories
{
    public class TeacherRepository
    {
        private readonly string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=lang-center;Integrated Security=True;Trust Server Certificate=True";

        public List<Teacher> GetTeachers()
        {
            var teachers = new List<Teacher>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM teachers ORDER BY id DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Teacher teacher = new Teacher();
                                teacher.id = reader.GetInt32(0);
                                teacher.firstName = reader.GetString(1);
                                teacher.lastName = reader.GetString(2);
                                teacher.userName = reader.GetString(3);
                                teacher.passKey = reader.GetString(4);
                                teacher.birthDate = reader.GetString(5);
                                teacher.phone = reader.GetString(6);

                                teachers.Add(teacher);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return teachers;
        }
    }
}
