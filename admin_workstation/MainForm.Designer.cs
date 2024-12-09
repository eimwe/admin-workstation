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
            btnAddPayment = new Button();
            dataGridView1 = new DataGridView();
            tabControlTables.SuspendLayout();
            tabPageClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            tabPagePayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControlTables
            // 
            tabControlTables.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlTables.Controls.Add(tabPageClients);
            tabControlTables.Controls.Add(tabPagePayments);
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
            tabPagePayments.Controls.Add(dataGridView1);
            tabPagePayments.Controls.Add(btnAddPayment);
            tabPagePayments.Location = new Point(4, 30);
            tabPagePayments.Name = "tabPagePayments";
            tabPagePayments.Size = new Size(768, 374);
            tabPagePayments.TabIndex = 1;
            tabPagePayments.Text = "Payments";
            tabPagePayments.UseVisualStyleBackColor = true;
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
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 34);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(762, 337);
            dataGridView1.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Button btnAddPayment;
    }
}