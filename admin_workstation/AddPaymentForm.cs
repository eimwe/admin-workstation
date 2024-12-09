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
    public partial class AddPaymentForm : Form
    {
        public AddPaymentForm()
        {
            InitializeComponent();
            LoadComboBoxData();
            this.DialogResult = DialogResult.Cancel;
        }

        private void LoadComboBoxData()
        {
            var clientRepo = new ClientRepository();
            var clients = clientRepo.GetClients();
            this.comboBoxClients.DataSource = clients.Select(c => new { Value = c.id, Display = c.firstName + " " + c.lastName }).ToList();
            this.comboBoxClients.DisplayMember = "Display";
            this.comboBoxClients.ValueMember = "Value";

            var courseRepo = new CourseRepository();
            var courses = courseRepo.GetCourses();
            this.comboBoxCourses.DataSource = courses.Select(c => new { Value = c.id, Display = c.title }).ToList();
            this.comboBoxCourses.DisplayMember = "Display";
            this.comboBoxCourses.ValueMember = "Value";
        }

        private void btnSavePayment_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.id = 0;
            payment.clientId = (int)((dynamic)this.comboBoxClients.SelectedItem).Value;
            payment.courseId = (int)((dynamic)this.comboBoxCourses.SelectedItem).Value;
            payment.amount = decimal.Parse(this.textBoxPayAmount.Text);
            payment.paymentDate = this.dateTimePickerPayment.Value;

            var repo = new PaymentRepository();
            repo.CreatePayment(payment);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelPayment_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
