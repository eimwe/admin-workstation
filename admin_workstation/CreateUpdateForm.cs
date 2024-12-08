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
    public partial class CreateUpdateForm : Form
    {
        public CreateUpdateForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private int clientId = 0;

        public void UpdateClient(Client client)
        {
            this.Text = "Update Client";
            this.labelTitle.Text = "Update Client";

            this.labelClientId.Text = "" + client.id;
            this.textBoxClientFirstName.Text = client.firstName;
            this.textBoxClientLastName.Text = client.lastName;
            this.textBoxClientBirthDate.Text = client.birthDate;
            this.textBoxClientPhone.Text = client.phone;

            this.clientId = client.id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.id = this.clientId;
            client.firstName = this.textBoxClientFirstName.Text;
            client.lastName = this.textBoxClientLastName.Text;
            client.birthDate = this.textBoxClientBirthDate.Text;
            client.phone = this.textBoxClientPhone.Text;

            var repo = new ClientRepository();

            if (client.id == 0)
            {
                repo.CreateClient(client);
            } else
            {
                repo.UpdateClient(client);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
