﻿using admin_workstation.Configs;
using admin_workstation.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_workstation.Repositories
{
    public class ClientRepository
    {
        private readonly string connectionString = DatabaseConfig.GetConnectionString();

        public List<Client> GetClients()
        {
            var clients = new List<Client>();

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM clients ORDER BY id DESC";
                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Client client = new Client();
                                client.id = reader.GetInt32(0);
                                client.firstName = reader.GetString(1);
                                client.lastName = reader.GetString(2);
                                client.birthDate = reader.GetString(3);
                                client.phone = reader.GetString(4);

                                clients.Add(client);
                            }
                        }
                    }
                }

            } catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

            return clients;
        }

        public Client? GetClient(int id)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM clients WHERE id=@id";
                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Client client = new Client();
                                client.id = reader.GetInt32(0);
                                client.firstName = reader.GetString(1);
                                client.lastName = reader.GetString(2);
                                client.birthDate = reader.GetString(3);
                                client.phone = reader.GetString(4);

                                return client;
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

        public void CreateClient(Client client)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO clients " +
                                 "(firstname, lastname, birthdate, phone) VALUES " +
                                 "(@firstname, @lastname, @birthdate, @phone);";
                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@firstname", client.firstName);
                        command.Parameters.AddWithValue("@lastname", client.lastName);
                        command.Parameters.AddWithValue("@birthdate", client.birthDate);
                        command.Parameters.AddWithValue("@phone", client.phone);

                        command.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        public void UpdateClient(Client client)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE clients " +
                                 "SET firstname=@firstname, lastname=@lastname, " +
                                 "birthdate=@birthdate, phone=@phone " +
                                 "WHERE id=@id";
                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", client.id);
                        command.Parameters.AddWithValue("@firstname", client.firstName);
                        command.Parameters.AddWithValue("@lastname", client.lastName);
                        command.Parameters.AddWithValue("@birthdate", client.birthDate);
                        command.Parameters.AddWithValue("@phone", client.phone);

                        command.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        public void DeleteClient(int id)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM clients WHERE id=@id";
                    using (var command = new SQLiteCommand(sql, connection))
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
