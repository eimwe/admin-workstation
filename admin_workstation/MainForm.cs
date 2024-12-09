using admin_workstation.Repositories;
using System.Data;

namespace admin_workstation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ReadClients();
            ReadPayments();
        }

        private void ReadClients()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Date of Birth");
            dataTable.Columns.Add("Phone");

            var repo = new ClientRepository();
            var clients = repo.GetClients();

            foreach (var client in clients)
            {
                var row = dataTable.NewRow();

                row["ID"] = client.id;
                row["Name"] = client.firstName + " " + client.lastName;
                row["Date of Birth"] = client.birthDate;
                row["Phone"] = client.phone;

                dataTable.Rows.Add(row);
            }

            this.dataGridViewClients.DataSource = dataTable;
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            CreateUpdateForm form = new CreateUpdateForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadClients();
            }
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            var value = this.dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null || value.Length == 0) return;

            int clientId = int.Parse(value);

            var repo = new ClientRepository();
            var client = repo.GetClient(clientId);

            if (client == null) return;

            CreateUpdateForm form = new CreateUpdateForm();
            form.UpdateClient(client);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadClients();
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            var value = this.dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null || value.Length == 0) return;

            int clientId = int.Parse(value);

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete this client?",
                "Delete Client",
                MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var repo = new ClientRepository();
            repo.DeleteClient(clientId);
            ReadClients();
        }

        private void ReadPayments()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Client");
            dataTable.Columns.Add("Course");
            dataTable.Columns.Add("Amount");
            dataTable.Columns.Add("Payment Date");

            var repo = new PaymentRepository();
            var payments = repo.GetPayments();

            foreach (var payment in payments)
            {
                var row = dataTable.NewRow();

                row["ID"] = payment.id;
                row["Client"] = payment.clientName;
                row["Course"] = payment.courseTitle;
                row["Amount"] = payment.amount;
                row["Payment Date"] = payment.paymentDate;

                dataTable.Rows.Add(row);
            }

            this.dataGridViewPayments.DataSource = dataTable;
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            AddPaymentForm form = new AddPaymentForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadPayments();
            }
        }
    }
}