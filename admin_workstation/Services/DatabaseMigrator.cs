using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data.SQLite;

namespace admin_workstation.Services
{
    public class DatabaseMigrator
    {
        private readonly string _sqlServerConnectionString;
        private readonly string _sqliteDbPath;

        public DatabaseMigrator(string sqlServerConnectionString, string sqliteDbPath)
        {
            _sqlServerConnectionString = sqlServerConnectionString;
            _sqliteDbPath = sqliteDbPath;
        }

        public void Migrate()
        {
            SQLiteConnection.CreateFile(_sqliteDbPath);

            using (var sqliteConnection = new SQLiteConnection($"Data Source={_sqliteDbPath};Version=3;"))
            using (var sqlServerConnection = new SqlConnection(_sqlServerConnectionString))
            {
                sqliteConnection.Open();
                sqlServerConnection.Open();

                CreateTables(sqliteConnection);

                MigrateClients(sqlServerConnection, sqliteConnection);
                MigrateTeachers(sqlServerConnection, sqliteConnection);
                MigrateCourses(sqlServerConnection, sqliteConnection);
                MigrateTeacherCourse(sqlServerConnection, sqliteConnection);
                MigrateClassrooms(sqlServerConnection, sqliteConnection);
            }
        }

        private void CreateTables(SQLiteConnection sqliteConnection)
        {
            string[] createTableCommands = new[]
            {
            @"CREATE TABLE clients (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                firstname TEXT NOT NULL,
                lastname TEXT NOT NULL,
                birthdate TEXT NOT NULL,
                phone TEXT NOT NULL
            )",
            @"CREATE TABLE teachers (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                firstname TEXT NOT NULL,
                lastname TEXT NOT NULL,
                username TEXT NOT NULL,
                passkey TEXT NOT NULL,
                birthdate TEXT NOT NULL,
                phone TEXT NOT NULL
            )",
            @"CREATE TABLE courses (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                title TEXT NOT NULL,
                about TEXT NOT NULL,
                duration INTEGER NOT NULL,
                totalprice INTEGER NOT NULL,
                monthprice INTEGER NOT NULL
            )",
            @"CREATE TABLE teacher_course (
                teacherId INTEGER NOT NULL,
                courseId INTEGER NOT NULL,
                PRIMARY KEY (teacherId, courseId),
                FOREIGN KEY (teacherId) REFERENCES teachers(id),
                FOREIGN KEY (courseId) REFERENCES courses(id)
            )",
            @"CREATE TABLE classrooms (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                room TEXT NOT NULL
            )",
            @"CREATE TABLE payments (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                clientId INTEGER NOT NULL,
                courseId INTEGER NOT NULL,
                amount REAL NOT NULL,
                paymentDate TEXT NOT NULL,
                FOREIGN KEY (clientId) REFERENCES clients(id),
                FOREIGN KEY (courseId) REFERENCES courses(id)
            )",
            @"CREATE TABLE timetable (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                clientId INTEGER NOT NULL,
                courseId INTEGER NOT NULL,
                teacherId INTEGER NOT NULL,
                classroomId INTEGER NOT NULL,
                lessonDate TEXT NOT NULL,
                FOREIGN KEY (clientId) REFERENCES clients(id),
                FOREIGN KEY (courseId) REFERENCES courses(id),
                FOREIGN KEY (teacherId) REFERENCES teachers(id),
                FOREIGN KEY (classroomId) REFERENCES classrooms(id)
            )"
        };

            foreach (var command in createTableCommands)
            {
                using (var cmd = new SQLiteCommand(command, sqliteConnection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void MigrateClients(SqlConnection source, SQLiteConnection destination)
        {
            var cmd = new SqlCommand("SELECT * FROM clients", source);
            var reader = cmd.ExecuteReader();

            using (var transaction = destination.BeginTransaction())
            {
                var insertCmd = new SQLiteCommand(
                    "INSERT INTO clients (firstname, lastname, birthdate, phone) VALUES (@firstname, @lastname, @birthdate, @phone)",
                    destination);

                while (reader.Read())
                {
                    insertCmd.Parameters.Clear();
                    insertCmd.Parameters.AddWithValue("@firstname", reader["firstname"]);
                    insertCmd.Parameters.AddWithValue("@lastname", reader["lastname"]);
                    insertCmd.Parameters.AddWithValue("@birthdate", reader["birthdate"]);
                    insertCmd.Parameters.AddWithValue("@phone", reader["phone"]);
                    insertCmd.ExecuteNonQuery();
                }

                transaction.Commit();
            }
        }

        private void MigrateTeachers(SqlConnection source, SQLiteConnection destination)
        {
            var cmd = new SqlCommand("SELECT * FROM teachers", source);
            var reader = cmd.ExecuteReader();

            using (var transaction = destination.BeginTransaction())
            {
                var insertCmd = new SQLiteCommand(
                    @"INSERT INTO teachers (firstname, lastname, username, passkey, birthdate, phone) 
                  VALUES (@firstname, @lastname, @username, @passkey, @birthdate, @phone)",
                    destination);

                while (reader.Read())
                {
                    insertCmd.Parameters.Clear();
                    insertCmd.Parameters.AddWithValue("@firstname", reader["firstname"]);
                    insertCmd.Parameters.AddWithValue("@lastname", reader["lastname"]);
                    insertCmd.Parameters.AddWithValue("@username", reader["username"]);
                    insertCmd.Parameters.AddWithValue("@passkey", reader["passkey"]);
                    insertCmd.Parameters.AddWithValue("@birthdate", reader["birthdate"]);
                    insertCmd.Parameters.AddWithValue("@phone", reader["phone"]);
                    insertCmd.ExecuteNonQuery();
                }

                transaction.Commit();
            }
        }

        private void MigrateCourses(SqlConnection source, SQLiteConnection destination)
        {
            var cmd = new SqlCommand("SELECT * FROM courses", source);
            var reader = cmd.ExecuteReader();

            using (var transaction = destination.BeginTransaction())
            {
                var insertCmd = new SQLiteCommand(
                    @"INSERT INTO courses (title, about, duration, totalprice, monthprice) 
              VALUES (@title, @about, @duration, @totalprice, @monthprice)",
                    destination);

                while (reader.Read())
                {
                    insertCmd.Parameters.Clear();
                    insertCmd.Parameters.AddWithValue("@title", reader["title"]);
                    insertCmd.Parameters.AddWithValue("@about", reader["about"]);
                    insertCmd.Parameters.AddWithValue("@duration", reader["duration"]);
                    insertCmd.Parameters.AddWithValue("@totalprice", reader["totalprice"]);
                    insertCmd.Parameters.AddWithValue("@monthprice", reader["monthprice"]);
                    insertCmd.ExecuteNonQuery();
                }

                transaction.Commit();
            }
        }

        private void MigrateTeacherCourse(SqlConnection source, SQLiteConnection destination)
        {
            var cmd = new SqlCommand("SELECT * FROM teacher_course", source);
            var reader = cmd.ExecuteReader();

            using (var transaction = destination.BeginTransaction())
            {
                var insertCmd = new SQLiteCommand(
                    "INSERT INTO teacher_course (teacherId, courseId) VALUES (@teacherId, @courseId)",
                    destination);

                while (reader.Read())
                {
                    insertCmd.Parameters.Clear();
                    insertCmd.Parameters.AddWithValue("@teacherId", reader["teacherId"]);
                    insertCmd.Parameters.AddWithValue("@courseId", reader["courseId"]);
                    insertCmd.ExecuteNonQuery();
                }

                transaction.Commit();
            }
        }

        private void MigrateClassrooms(SqlConnection source, SQLiteConnection destination)
        {
            var cmd = new SqlCommand("SELECT * FROM classrooms", source);
            var reader = cmd.ExecuteReader();

            using (var transaction = destination.BeginTransaction())
            {
                var insertCmd = new SQLiteCommand(
                    @"INSERT INTO classrooms (room) 
              VALUES (@room)",
                    destination);

                while (reader.Read())
                {
                    insertCmd.Parameters.Clear();
                    insertCmd.Parameters.AddWithValue("@room", reader["room"]);
                    insertCmd.ExecuteNonQuery();
                }

                transaction.Commit();
            }
        }
    }
}
