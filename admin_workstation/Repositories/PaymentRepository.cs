using admin_workstation.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_workstation.Repositories
{
    public class PaymentRepository
    {
        private readonly string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=lang-center;Integrated Security=True;Trust Server Certificate=True";

        public List<Payment> GetPayments()
        {
            var payments = new List<Payment>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM payments ORDER BY id DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Payment payment = new Payment();
                                payment.id = reader.GetInt32(0);
                                payment.clientId = reader.GetInt32(1);
                                payment.courseId = reader.GetInt32(2);
                                payment.amount = reader.GetDecimal(3);
                                payment.paymentDate = reader.GetDateTime(4);
                                
                                payments.Add(payment);
                            }
                        }
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return payments;
        }

        public void CreatePayment(Payment payment)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO payments " +
                                 "(clientId, courseId, amount, paymentDate) VALUES " +
                                 "(@clientId, @courseId, @amount, @paymentDate);";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@firstname", payment.clientId);
                        command.Parameters.AddWithValue("@lastname", payment.courseId);
                        command.Parameters.AddWithValue("@birthdate", payment.amount);
                        command.Parameters.AddWithValue("@phone", payment.paymentDate);

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
