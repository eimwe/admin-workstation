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
            btnDeleteClient = new Button();
            btnUpdateClient = new Button();
            btnAddClient = new Button();
            dataGridView1 = new DataGridView();
            tabControlTables.SuspendLayout();
            tabPageClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControlTables
            // 
            tabControlTables.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlTables.Controls.Add(tabPageClients);
            tabControlTables.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlTables.Location = new Point(12, 12);
            tabControlTables.Multiline = true;
            tabControlTables.Name = "tabControlTables";
            tabControlTables.SelectedIndex = 0;
            tabControlTables.Size = new Size(776, 426);
            tabControlTables.TabIndex = 0;
            // 
            // tabPageClients
            // 
            tabPageClients.Controls.Add(dataGridView1);
            tabPageClients.Controls.Add(btnAddClient);
            tabPageClients.Controls.Add(btnUpdateClient);
            tabPageClients.Controls.Add(btnDeleteClient);
            tabPageClients.Location = new Point(4, 30);
            tabPageClients.Name = "tabPageClients";
            tabPageClients.Padding = new Padding(3);
            tabPageClients.Size = new Size(768, 392);
            tabPageClients.TabIndex = 0;
            tabPageClients.Text = "Clients";
            tabPageClients.UseVisualStyleBackColor = true;
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
            // 
            // btnAddClient
            // 
            btnAddClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddClient.AutoSize = true;
            btnAddClient.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddClient.Location = new Point(488, 6);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(89, 25);
            btnAddClient.TabIndex = 0;
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 37);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(756, 349);
            dataGridView1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlTables);
            Name = "MainForm";
            Text = "Language Center Admin Workstation";
            tabControlTables.ResumeLayout(false);
            tabPageClients.ResumeLayout(false);
            tabPageClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlTables;
        private TabPage tabPageClients;
        private DataGridView dataGridView1;
        private Button btnAddClient;
        private Button btnUpdateClient;
        private Button btnDeleteClient;
    }
}