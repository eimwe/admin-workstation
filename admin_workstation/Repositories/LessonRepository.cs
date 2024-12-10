﻿using admin_workstation.Models;
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
    }
}
