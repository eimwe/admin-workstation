﻿namespace admin_workstation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControlTables = new TabControl();
            tabPageClients = new TabPage();
            textBoxClientSearch = new TextBox();
            btnExportClients = new Button();
            btnPrintContract = new Button();
            dataGridViewClients = new DataGridView();
            btnCreateClient = new Button();
            btnUpdateClient = new Button();
            btnDeleteClient = new Button();
            tabPagePayments = new TabPage();
            btnExportPayments = new Button();
            textBoxPaymentSearch = new TextBox();
            dataGridViewPayments = new DataGridView();
            btnShowDebts = new Button();
            btnAddPayment = new Button();
            tabPage1 = new TabPage();
            btnExportLessons = new Button();
            textBoxLessonSearch = new TextBox();
            dataGridViewTimetable = new DataGridView();
            btnAddLesson = new Button();
            btnUpdateLesson = new Button();
            btnDeleteLesson = new Button();
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
            tabPageClients.Controls.Add(textBoxClientSearch);
            tabPageClients.Controls.Add(btnExportClients);
            tabPageClients.Controls.Add(btnPrintContract);
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
            // textBoxClientSearch
            // 
            textBoxClientSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxClientSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxClientSearch.Location = new Point(68, 7);
            textBoxClientSearch.Name = "textBoxClientSearch";
            textBoxClientSearch.PlaceholderText = "Search for clients info...";
            textBoxClientSearch.Size = new Size(414, 23);
            textBoxClientSearch.TabIndex = 2;
            // 
            // btnExportClients
            // 
            btnExportClients.BackgroundImage = (Image)resources.GetObject("btnExportClients.BackgroundImage");
            btnExportClients.BackgroundImageLayout = ImageLayout.Zoom;
            btnExportClients.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExportClients.Location = new Point(37, 6);
            btnExportClients.MaximumSize = new Size(25, 25);
            btnExportClients.MinimumSize = new Size(25, 25);
            btnExportClients.Name = "btnExportClients";
            btnExportClients.Size = new Size(25, 25);
            btnExportClients.TabIndex = 0;
            btnExportClients.UseVisualStyleBackColor = true;
            btnExportClients.Click += btnExportClients_Click;
            // 
            // btnPrintContract
            // 
            btnPrintContract.BackgroundImage = (Image)resources.GetObject("btnPrintContract.BackgroundImage");
            btnPrintContract.BackgroundImageLayout = ImageLayout.Zoom;
            btnPrintContract.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrintContract.Location = new Point(6, 6);
            btnPrintContract.MaximumSize = new Size(25, 25);
            btnPrintContract.MinimumSize = new Size(25, 25);
            btnPrintContract.Name = "btnPrintContract";
            btnPrintContract.Size = new Size(25, 25);
            btnPrintContract.TabIndex = 0;
            btnPrintContract.UseVisualStyleBackColor = true;
            btnPrintContract.Click += btnPrintContract_Click;
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
            tabPagePayments.Controls.Add(btnExportPayments);
            tabPagePayments.Controls.Add(textBoxPaymentSearch);
            tabPagePayments.Controls.Add(dataGridViewPayments);
            tabPagePayments.Controls.Add(btnShowDebts);
            tabPagePayments.Controls.Add(btnAddPayment);
            tabPagePayments.Location = new Point(4, 30);
            tabPagePayments.Name = "tabPagePayments";
            tabPagePayments.Size = new Size(768, 374);
            tabPagePayments.TabIndex = 1;
            tabPagePayments.Text = "Payments";
            tabPagePayments.UseVisualStyleBackColor = true;
            // 
            // btnExportPayments
            // 
            btnExportPayments.BackgroundImage = (Image)resources.GetObject("btnExportPayments.BackgroundImage");
            btnExportPayments.BackgroundImageLayout = ImageLayout.Zoom;
            btnExportPayments.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExportPayments.Location = new Point(3, 5);
            btnExportPayments.MaximumSize = new Size(25, 25);
            btnExportPayments.MinimumSize = new Size(25, 25);
            btnExportPayments.Name = "btnExportPayments";
            btnExportPayments.Size = new Size(25, 25);
            btnExportPayments.TabIndex = 5;
            btnExportPayments.UseVisualStyleBackColor = true;
            btnExportPayments.Click += btnExportPayments_Click;
            // 
            // textBoxPaymentSearch
            // 
            textBoxPaymentSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPaymentSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPaymentSearch.Location = new Point(161, 5);
            textBoxPaymentSearch.Name = "textBoxPaymentSearch";
            textBoxPaymentSearch.PlaceholderText = "Search for payments info...";
            textBoxPaymentSearch.Size = new Size(414, 23);
            textBoxPaymentSearch.TabIndex = 4;
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
            // btnShowDebts
            // 
            btnShowDebts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShowDebts.AutoSize = true;
            btnShowDebts.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowDebts.Location = new Point(581, 3);
            btnShowDebts.Name = "btnShowDebts";
            btnShowDebts.Size = new Size(89, 25);
            btnShowDebts.TabIndex = 0;
            btnShowDebts.Text = "Show Debts";
            btnShowDebts.UseVisualStyleBackColor = true;
            btnShowDebts.Click += btnShowDebts_Click;
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
            tabPage1.Controls.Add(btnExportLessons);
            tabPage1.Controls.Add(textBoxLessonSearch);
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
            // btnExportLessons
            // 
            btnExportLessons.BackgroundImage = (Image)resources.GetObject("btnExportLessons.BackgroundImage");
            btnExportLessons.BackgroundImageLayout = ImageLayout.Zoom;
            btnExportLessons.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExportLessons.Location = new Point(3, 5);
            btnExportLessons.MaximumSize = new Size(25, 25);
            btnExportLessons.MinimumSize = new Size(25, 25);
            btnExportLessons.Name = "btnExportLessons";
            btnExportLessons.Size = new Size(25, 25);
            btnExportLessons.TabIndex = 6;
            btnExportLessons.UseVisualStyleBackColor = true;
            btnExportLessons.Click += btnExportLessons_Click;
            // 
            // textBoxLessonSearch
            // 
            textBoxLessonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLessonSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLessonSearch.Location = new Point(56, 5);
            textBoxLessonSearch.Name = "textBoxLessonSearch";
            textBoxLessonSearch.PlaceholderText = "Search for lessons info...";
            textBoxLessonSearch.Size = new Size(414, 23);
            textBoxLessonSearch.TabIndex = 3;
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
            btnAddLesson.Click += btnAddLesson_Click;
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
            btnUpdateLesson.Click += btnUpdateLesson_Click;
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
            btnDeleteLesson.Click += btnDeleteLesson_Click;
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
        private Button btnPrintContract;
        private Button btnExportClients;
        private Button btnShowDebts;
        private TextBox textBoxClientSearch;
        private TextBox textBoxLessonSearch;
        private TextBox textBoxPaymentSearch;
        private Button btnExportPayments;
        private Button btnExportLessons;
    }
}