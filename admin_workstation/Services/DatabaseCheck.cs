using admin_workstation.Configs;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_workstation.Services
{
    public class DatabaseCheck
    {
        public static bool VerifyDatabase()
        {
            try
            {
                using (var connection = new SQLiteConnection(DatabaseConfig.GetConnectionString()))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM clients", connection))
                    {
                        cmd.ExecuteScalar();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database verification failed: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
