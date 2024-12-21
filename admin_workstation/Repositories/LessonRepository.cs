using admin_workstation.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_workstation.Repositories
{
    public class LessonRepository
    {
        private readonly string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=lang-center;Integrated Security=True;Trust Server Certificate=True";

        public List<Lesson> GetLessons()
        {
            var lessons = new List<Lesson>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT " +
                                    "timetable.id, " +
                                    "timetable.clientId, " +
                                    "clients.firstName + ' ' + clients.lastName as clientName, " +
                                    "timetable.courseId, " +
                                    "courses.title as courseTitle, " +
                                    "timetable.teacherId, " +
                                    "teachers.firstName + ' ' + teachers.lastName as teacherName, " +
                                    "timetable.classroomId, " +
                                    "classrooms.room as classroomNumber, " +
                                    "timetable.lessonDate " +
                                 "FROM " +
                                    "timetable " +
                                 "JOIN clients ON timetable.clientId = clients.id " +
                                 "JOIN courses ON timetable.courseId = courses.id " +
                                 "JOIN teachers ON timetable.teacherId = teachers.id " +
                                 "JOIN classrooms ON timetable.classroomId = classrooms.id " +
                                 "ORDER BY timetable.id DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Lesson lesson = new Lesson();
                                lesson.id = reader.GetInt32(0);
                                lesson.clientId = reader.GetInt32(1);
                                lesson.clientName = reader.GetString(2);
                                lesson.courseId = reader.GetInt32(3);
                                lesson.courseTitle = reader.GetString(4);
                                lesson.teacherId = reader.GetInt32(5);
                                lesson.teacherName = reader.GetString(6);
                                lesson.classroomId = reader.GetInt32(7);
                                lesson.classroomNumber = reader.GetString(8);
                                lesson.lessonDate = reader.GetDateTime(9);

                                lessons.Add(lesson);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Full Exception Details:");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                throw;
            }

            return lessons;
        }

        public Lesson? GetLesson(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT " +
                                "timetable.id, " +
                                "timetable.clientId, " +
                                "clients.firstName + ' ' + clients.lastName as clientName, " +
                                "timetable.courseId, " +
                                "courses.title as courseTitle, " +
                                "timetable.teacherId, " +
                                "teachers.firstName + ' ' + teachers.lastName as teacherName, " +
                                "timetable.classroomId, " +
                                "classrooms.room as classroomNumber, " +
                                "timetable.lessonDate " +
                             "FROM " +
                                "timetable " +
                             "JOIN clients ON timetable.clientId = clients.id " +
                             "JOIN courses ON timetable.courseId = courses.id " +
                             "JOIN teachers ON timetable.teacherId = teachers.id " +
                             "JOIN classrooms ON timetable.classroomId = classrooms.id " +
                             "WHERE timetable.id = @id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Lesson lesson = new Lesson();
                                lesson.id = reader.GetInt32(0);
                                lesson.clientId = reader.GetInt32(1);
                                lesson.clientName = reader.GetString(2);
                                lesson.courseId = reader.GetInt32(3);
                                lesson.courseTitle = reader.GetString(4);
                                lesson.teacherId = reader.GetInt32(5);
                                lesson.teacherName = reader.GetString(6);
                                lesson.classroomId = reader.GetInt32(7);
                                lesson.classroomNumber = reader.GetString(8);
                                lesson.lessonDate = reader.GetDateTime(9);

                                return lesson;
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return null;
        }

        public void AddLesson(Lesson lesson)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO timetable " +
                                 "(clientId, courseId, teacherId, classroomId, lessonDate) VALUES " +
                                 "(@clientId, @courseId, @teacherId, @classroomId, @lessonDate);";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@clientId", lesson.clientId);
                        command.Parameters.AddWithValue("@courseId", lesson.courseId);
                        command.Parameters.AddWithValue("@teacherId", lesson.teacherId);
                        command.Parameters.AddWithValue("@classroomId", lesson.classroomId);
                        command.Parameters.AddWithValue("@lessonDate", lesson.lessonDate);

                        command.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        public void UpdateLesson(Lesson lesson)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE timetable " +
                                 "SET clientId=@clientId, courseId=@courseId, " +
                                 "teacherId=@teacherId, classroomId=@classroomId, " +
                                 "lessonDate=@lessonDate WHERE id=@id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", lesson.id);
                        command.Parameters.AddWithValue("@clientId", lesson.clientId);
                        command.Parameters.AddWithValue("@courseId", lesson.courseId);
                        command.Parameters.AddWithValue("@teacherId", lesson.teacherId);
                        command.Parameters.AddWithValue("@classroomId", lesson.classroomId);
                        command.Parameters.AddWithValue("@lessonDate", lesson.lessonDate);

                        command.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        public void DeleteLesson(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM timetable WHERE id=@id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        command.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }
    }
}
