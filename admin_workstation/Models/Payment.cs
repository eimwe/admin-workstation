﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_workstation.Models
{
    public class Payment
    {
        public int id;
        public int clientId;
        public string clientName = "";
        public int courseId;
        public string courseTitle = "";
        public decimal amount = 0;
        public DateTime paymentDate = DateTime.Now;
    }
}
