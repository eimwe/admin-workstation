using admin_workstation.Models;
using admin_workstation.Repositories;
using admin_workstation.Services;
using System.Data;
using System.Windows.Forms;

namespace admin_workstation
{
    public partial class MainForm : Form
    {
        private DataSearcher? clientSearchHelper;
        public MainForm()
        {
            if (!DatabaseCheck.VerifyDatabase())
            {
                Application.Exit();
                return;
            }

            InitializeComponent();
            ReadClients();
            ReadPayments();
            ReadLessons();

            clientSearchHelper = new DataSearcher(dataGridViewClients, textBoxClientSearch);
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
            this.dataGridViewClients.Columns["ID"].Visible = false;
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
            this.dataGridViewPayments.Columns["ID"].Visible = false;
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            AddPaymentForm form = new AddPaymentForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadPayments();
            }
        }

        private void btnShowDebts_Click(object sender, EventArgs e)
        {
            DebtForm form = new DebtForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadPayments();
            }
        }

        private void ReadLessons()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Client");
            dataTable.Columns.Add("Course");
            dataTable.Columns.Add("Teacher");
            dataTable.Columns.Add("Classroom");
            dataTable.Columns.Add("Lesson Date");
            dataTable.Columns.Add("Lesson Time");

            var repo = new LessonRepository();
            var lessons = repo.GetLessons();

            foreach (var lesson in lessons)
            {
                var row = dataTable.NewRow();

                row["ID"] = lesson.id;
                row["Client"] = lesson.clientName;
                row["Course"] = lesson.courseTitle;
                row["Teacher"] = lesson.teacherName;
                row["Classroom"] = lesson.classroomNumber;
                row["Lesson Date"] = lesson.lessonDate;
                row["Lesson Time"] = lesson.timeSlot.ToDisplayString();

                dataTable.Rows.Add(row);
            }

            this.dataGridViewTimetable.DataSource = dataTable;
            this.dataGridViewTimetable.Columns["ID"].Visible = false;
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            AddUpdateLessonForm form = new AddUpdateLessonForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadLessons();
            }
        }

        private void btnUpdateLesson_Click(object sender, EventArgs e)
        {
            try
            {
                var value = this.dataGridViewTimetable.SelectedRows[0].Cells[0].Value.ToString();
                if (value == null || value.Length == 0) return;

                int lessonId = int.Parse(value);

                var repo = new LessonRepository();
                var lesson = repo.GetLesson(lessonId);

                if (lesson == null) return;
                AddUpdateLessonForm form = new AddUpdateLessonForm();
                form.UpdateLesson(lesson);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ReadLessons();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

        }

        private void btnDeleteLesson_Click(object sender, EventArgs e)
        {
            var value = this.dataGridViewTimetable.SelectedRows[0].Cells[0].Value.ToString();
            if (value == null || value.Length == 0) return;

            int lessontId = int.Parse(value);

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete this lesson?",
                "Delete Lesson",
                MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var repo = new LessonRepository();
            repo.DeleteLesson(lessontId);
            ReadLessons();
        }

        private void btnPrintContract_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewClients.SelectedRows[0];

                string fullName = $"{row.Cells["Name"].Value}";
                string dateOfBirth = $"{row.Cells["Date of Birth"].Value}";
                string phoneNumber = $"{row.Cells["Phone"].Value}";

                var generator = new ContractGenerator();
                generator.GenerateContract(fullName, dateOfBirth, phoneNumber);
            }
            else
            {
                MessageBox.Show("Please select a client first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExportClients_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.Rows.Count > 0)
            {
                var exporter = new TableExporter();
                exporter.ExportDataGridToPdf(dataGridViewClients, "Clients List");
            }
            else
            {
                MessageBox.Show("No data to export.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}