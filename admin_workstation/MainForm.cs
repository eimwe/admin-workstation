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

            Console.WriteLine(clients.Count);

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
    }
}