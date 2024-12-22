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
    public class PaymentRepository
    {
        private readonly string connectionString = DatabaseConfig.GetConnectionString();

        public List<Payment> GetPayments()
        {
            var payments = new List<Payment>();

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT " +
                                    "payments.id, " +
                                    "payments.clientId, " +
                                    "clients.firstName || ' ' || clients.lastName as clientName, " +
                                    "payments.courseId, " +
                                    "courses.title as courseTitle, " +
                                    "payments.amount, " +
                                    "payments.paymentDate " +
                                 "FROM " +
                                    "payments " +
                                 "JOIN " +
                                    "clients ON payments.clientId = clients.id " +
                                 "JOIN courses ON payments.courseId = courses.id " +
                                 "ORDER BY payments.id DESC";
                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Payment payment = new Payment();
                                payment.id = reader.GetInt32(0);
                                payment.clientId = reader.GetInt32(1);
                                payment.clientName = reader.GetString(2);
                                payment.courseId = reader.GetInt32(3);
                                payment.courseTitle = reader.GetString(4);
                                payment.amount = reader.GetDecimal(5);
                                payment.paymentDate = reader.GetDateTime(6);

                                payments.Add(payment);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return payments;
        }

        public void CreatePayment(Payment payment)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO payments " +
                                 "(clientId, courseId, amount, paymentDate) VALUES " +
                                 "(@clientId, @courseId, @amount, @paymentDate);";
                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@clientId", payment.clientId);
                        command.Parameters.AddWithValue("@courseId", payment.courseId);
                        command.Parameters.AddWithValue("@amount", payment.amount);
                        command.Parameters.AddWithValue("@paymentDate", payment.paymentDate);

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
