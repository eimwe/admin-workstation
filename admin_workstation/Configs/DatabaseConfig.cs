using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_workstation.Configs
{
    public static class DatabaseConfig
    {
        public static string GetConnectionString()
        {
            string dbPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "language-center.db"
            );

            return $"Data Source={dbPath};Version=3;";
        }
    }
}
