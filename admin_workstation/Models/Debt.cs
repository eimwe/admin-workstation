using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_workstation.Models
{
    public class Debt
    {
        public int clientId;
        public string clientName = "";
        public int courseId;
        public string courseTitle = "";
        public decimal totalPrice = 0;
        public decimal monthlyPrice = 0;
        public decimal totalPaid = 0;
        public decimal remainingDebt = 0;
        public DateTime lastPaymentDate = DateTime.Now;
        public int monthsLate;
    }
}
