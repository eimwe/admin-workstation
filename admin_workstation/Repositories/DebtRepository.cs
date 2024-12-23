using admin_workstation.Configs;
using admin_workstation.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace admin_workstation.Repositories
{
    public class DebtRepository
    {
        private readonly string connectionString = DatabaseConfig.GetConnectionString();

        private (string title, decimal totalPrice, decimal monthlyPrice) GetCourseDetails(SQLiteConnection connection, int courseId)
        {
            string sql = @"SELECT title, totalprice, monthprice 
                          FROM courses 
                          WHERE id = @courseId";

            using (var command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@courseId", courseId);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string title = reader.GetString(reader.GetOrdinal("title"));
                        decimal totalPrice = reader.GetDecimal(reader.GetOrdinal("totalprice"));
                        decimal monthPrice = reader.GetDecimal(reader.GetOrdinal("monthprice"));

                        return (title, totalPrice, monthPrice);
                    }
                }
            }
            return (string.Empty, 0, 0);
        }
    }
}
