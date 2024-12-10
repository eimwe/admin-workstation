namespace admin_workstation
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlTables = new TabControl();
            tabPageClients = new TabPage();
            dataGridViewClients = new DataGridView();
            btnCreateClient = new Button();
            btnUpdateClient = new Button();
            btnDeleteClient = new Button();
            tabPagePayments = new TabPage();
            dataGridViewPayments = new DataGridView();
            btnAddPayment = new Button();
            tabPage1 = new TabPage();
            btnDeleteLesson = new Button();
            btnUpdateLesson = new Button();
            btnAddLesson = new Button();
            dataGridViewTimetable = new DataGridView();
            tabControlTables.SuspendLayout();
            tabPageClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            tabPagePayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTimetable).BeginInit();
            SuspendLayout();
            // 
            // tabControlTables
            // 
            tabControlTables.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlTables.Controls.Add(tabPageClients);
            tabControlTables.Controls.Add(tabPagePayments);
            tabControlTables.Controls.Add(tabPage1);
            tabControlTables.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlTables.Location = new Point(12, 12);
            tabControlTables.Multiline = true;
            tabControlTables.Name = "tabControlTables";
            tabControlTables.SelectedIndex = 0;
            tabControlTables.Size = new Size(776, 408);
            tabControlTables.TabIndex = 0;
            // 
            // tabPageClients
            // 
            tabPageClients.Controls.Add(dataGridViewClients);
            tabPageClients.Controls.Add(btnCreateClient);
            tabPageClients.Controls.Add(btnUpdateClient);
            tabPageClients.Controls.Add(btnDeleteClient);
            tabPageClients.Location = new Point(4, 30);
            tabPageClients.Name = "tabPageClients";
            tabPageClients.Padding = new Padding(3);
            tabPageClients.Size = new Size(768, 374);
            tabPageClients.TabIndex = 0;
            tabPageClients.Text = "Clients";
            tabPageClients.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Location = new Point(6, 37);
            dataGridViewClients.MultiSelect = false;
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.RowHeadersVisible = false;
            dataGridViewClients.RowTemplate.Height = 25;
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClients.Size = new Size(756, 331);
            dataGridViewClients.TabIndex = 1;
            // 
            // btnCreateClient
            // 
            btnCreateClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateClient.AutoSize = true;
            btnCreateClient.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateClient.Location = new Point(488, 6);
            btnCreateClient.Name = "btnCreateClient";
            btnCreateClient.Size = new Size(89, 25);
            btnCreateClient.TabIndex = 0;
            btnCreateClient.Text = "Create Client";
            btnCreateClient.UseVisualStyleBackColor = true;
            btnCreateClient.Click += btnCreateClient_Click;
            // 
            // btnUpdateClient
            // 
            btnUpdateClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdateClient.AutoSize = true;
            btnUpdateClient.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateClient.Location = new Point(583, 6);
            btnUpdateClient.Name = "btnUpdateClient";
            btnUpdateClient.Size = new Size(89, 25);
            btnUpdateClient.TabIndex = 0;
            btnUpdateClient.Text = "Update Client";
            btnUpdateClient.UseVisualStyleBackColor = true;
            btnUpdateClient.Click += btnUpdateClient_Click;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteClient.AutoSize = true;
            btnDeleteClient.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteClient.Location = new Point(678, 6);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(84, 25);
            btnDeleteClient.TabIndex = 0;
            btnDeleteClient.Text = "Delete Client";
            btnDeleteClient.UseVisualStyleBackColor = true;
            btnDeleteClient.Click += btnDeleteClient_Click;
            // 
            // tabPagePayments
            // 
            tabPagePayments.Controls.Add(dataGridViewPayments);
            tabPagePayments.Controls.Add(btnAddPayment);
            tabPagePayments.Location = new Point(4, 30);
            tabPagePayments.Name = "tabPagePayments";
            tabPagePayments.Size = new Size(768, 374);
            tabPagePayments.TabIndex = 1;
            tabPagePayments.Text = "Payments";
            tabPagePayments.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPayments
            // 
            dataGridViewPayments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPayments.Location = new Point(3, 34);
            dataGridViewPayments.MultiSelect = false;
            dataGridViewPayments.Name = "dataGridViewPayments";
            dataGridViewPayments.RowHeadersVisible = false;
            dataGridViewPayments.RowTemplate.Height = 25;
            dataGridViewPayments.Size = new Size(762, 337);
            dataGridViewPayments.TabIndex = 1;
            // 
            // btnAddPayment
            // 
            btnAddPayment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddPayment.AutoSize = true;
            btnAddPayment.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddPayment.Location = new Point(676, 3);
            btnAddPayment.Name = "btnAddPayment";
            btnAddPayment.Size = new Size(89, 25);
            btnAddPayment.TabIndex = 0;
            btnAddPayment.Text = "Add Payment";
            btnAddPayment.UseVisualStyleBackColor = true;
            btnAddPayment.Click += btnAddPayment_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewTimetable);
            tabPage1.Controls.Add(btnAddLesson);
            tabPage1.Controls.Add(btnUpdateLesson);
            tabPage1.Controls.Add(btnDeleteLesson);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(768, 374);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Timetable";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteLesson
            // 
            btnDeleteLesson.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteLesson.AutoSize = true;
            btnDeleteLesson.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteLesson.Location = new Point(676, 3);
            btnDeleteLesson.Name = "btnDeleteLesson";
            btnDeleteLesson.Size = new Size(89, 25);
            btnDeleteLesson.TabIndex = 0;
            btnDeleteLesson.Text = "Delete Lesson";
            btnDeleteLesson.UseVisualStyleBackColor = true;
            // 
            // btnUpdateLesson
            // 
            btnUpdateLesson.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdateLesson.AutoSize = true;
            btnUpdateLesson.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateLesson.Location = new Point(576, 3);
            btnUpdateLesson.Name = "btnUpdateLesson";
            btnUpdateLesson.Size = new Size(94, 25);
            btnUpdateLesson.TabIndex = 0;
            btnUpdateLesson.Text = "Update Lesson";
            btnUpdateLesson.UseVisualStyleBackColor = true;
            // 
            // btnAddLesson
            // 
            btnAddLesson.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddLesson.AutoSize = true;
            btnAddLesson.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddLesson.Location = new Point(476, 3);
            btnAddLesson.Name = "btnAddLesson";
            btnAddLesson.Size = new Size(94, 25);
            btnAddLesson.TabIndex = 0;
            btnAddLesson.Text = "Add Lesson";
            btnAddLesson.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTimetable
            // 
            dataGridViewTimetable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTimetable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTimetable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTimetable.Location = new Point(3, 34);
            dataGridViewTimetable.MultiSelect = false;
            dataGridViewTimetable.Name = "dataGridViewTimetable";
            dataGridViewTimetable.RowHeadersVisible = false;
            dataGridViewTimetable.RowTemplate.Height = 25;
            dataGridViewTimetable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTimetable.Size = new Size(762, 337);
            dataGridViewTimetable.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 432);
            Controls.Add(tabControlTables);
            Name = "MainForm";
            Text = "Language Center Admin Workstation";
            tabControlTables.ResumeLayout(false);
            tabPageClients.ResumeLayout(false);
            tabPageClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            tabPagePayments.ResumeLayout(false);
            tabPagePayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTimetable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlTables;
        private TabPage tabPageClients;
        private DataGridView dataGridViewClients;
        private Button btnCreateClient;
        private Button btnUpdateClient;
        private Button btnDeleteClient;
        private TabPage tabPagePayments;
        private DataGridView dataGridViewPayments;
        private Button btnAddPayment;
        private TabPage tabPage1;
        private DataGridView dataGridViewTimetable;
        private Button btnAddLesson;
        private Button btnUpdateLesson;
        private Button btnDeleteLesson;
    }
}