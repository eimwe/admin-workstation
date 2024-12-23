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

        private (decimal totalPaid, DateTime lastPaymentDate) GetPaymentDetails(SQLiteConnection connection, int clientId, int courseId)
        {
            string sql = @"SELECT SUM(amount) as total_paid, MAX(paymentDate) as last_payment
                  FROM payments 
                  WHERE clientid = @clientId AND courseid = @courseId";

            using (var command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@clientId", clientId);
                command.Parameters.AddWithValue("@courseId", courseId);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        decimal totalPaid = reader.IsDBNull(reader.GetOrdinal("total_paid"))
                            ? 0
                            : reader.GetDecimal(reader.GetOrdinal("total_paid"));

                        DateTime lastPaymentDate = reader.IsDBNull(reader.GetOrdinal("last_payment"))
                            ? DateTime.MinValue
                            : reader.GetDateTime(reader.GetOrdinal("last_payment"));

                        return (totalPaid, lastPaymentDate);
                    }
                }
            }
            return (0, DateTime.MinValue);
        }

        public List<Debt> CalculateDebts()
        {
            var debts = new List<Debt>();

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT DISTINCT clientId, courseId FROM payments";
                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int clientId = Convert.ToInt32(reader["clientId"]);
                                int courseId = Convert.ToInt32(reader["courseId"]);

                                var courseDetails = GetCourseDetails(connection, courseId);
                                var paymentDetails = GetPaymentDetails(connection, clientId, courseId);

                                int monthsLate = 0;
                                if (paymentDetails.lastPaymentDate != DateTime.MinValue)
                                {
                                    var monthsSinceLastPayment = (DateTime.Now - paymentDetails.lastPaymentDate).Days / 30;
                                    var expectedPayments = Math.Ceiling(paymentDetails.totalPaid / courseDetails.monthlyPrice);
                                    monthsLate = (int)Math.Max(0, monthsSinceLastPayment - expectedPayments);
                                }

                                var debt = new Debt
                                {
                                    clientId = clientId,
                                    courseId = courseId,
                                    courseTitle = courseDetails.title,
                                    totalPrice = courseDetails.totalPrice,
                                    monthlyPrice = courseDetails.monthlyPrice,
                                    totalPaid = paymentDetails.totalPaid,
                                    remainingDebt = courseDetails.totalPrice - paymentDetails.totalPaid,
                                    lastPaymentDate = paymentDetails.lastPaymentDate,
                                    monthsLate = monthsLate
                                };

                                debts.Add(debt);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return debts;
        }
    }
}
