using admin_workstation.Models;
using admin_workstation.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin_workstation
{
    public partial class DebtForm : Form
    {
        public DebtForm()
        {
            InitializeComponent();
            LoadDebts();
            this.DialogResult = DialogResult.Cancel;
        }

        private void LoadDebts()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Client ID");
            dataTable.Columns.Add("Client Name");
            dataTable.Columns.Add("Course");
            dataTable.Columns.Add("Total Price");
            dataTable.Columns.Add("Monthly Price");
            dataTable.Columns.Add("Paid in Total");
            dataTable.Columns.Add("Remaining Debt");
            dataTable.Columns.Add("Last Paid Date");
            dataTable.Columns.Add("Months Late");

            var repo = new DebtRepository();
            var debts = repo.CalculateDebts();

            foreach (var debt in debts)
            {
                var row = dataTable.NewRow();

                row["Client ID"] = debt.clientId;
                row["Client Name"] = debt.clientName;
                row["Course"] = debt.courseTitle;
                row["Total Price"] = debt.totalPrice;
                row["Monthly Price"] = debt.monthlyPrice;
                row["Paid in Total"] = debt.totalPaid;
                row["Remaining Debt"] = debt.remainingDebt;
                row["Last Paid Date"] = debt.lastPaymentDate;
                row["Months Late"] = debt.monthsLate;

                dataTable.Rows.Add(row);
            }

            this.dataGridViewDebts.DataSource = dataTable;
        }

        private void btnCloseDebtView_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
