namespace admin_workstation
{
    partial class DebtForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridViewDebts = new DataGridView();
            btnCloseDebtView = new Button();
            btnExportDebtView = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDebts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(776, 23);
            label1.TabIndex = 0;
            label1.Text = "Current Debts";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridViewDebts
            // 
            dataGridViewDebts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDebts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDebts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDebts.Location = new Point(12, 35);
            dataGridViewDebts.MultiSelect = false;
            dataGridViewDebts.Name = "dataGridViewDebts";
            dataGridViewDebts.RowHeadersVisible = false;
            dataGridViewDebts.RowTemplate.Height = 25;
            dataGridViewDebts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDebts.Size = new Size(776, 374);
            dataGridViewDebts.TabIndex = 1;
            // 
            // btnCloseDebtView
            // 
            btnCloseDebtView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnCloseDebtView.Location = new Point(713, 415);
            btnCloseDebtView.Name = "btnCloseDebtView";
            btnCloseDebtView.Size = new Size(75, 23);
            btnCloseDebtView.TabIndex = 0;
            btnCloseDebtView.Text = "Close";
            btnCloseDebtView.UseVisualStyleBackColor = true;
            btnCloseDebtView.Click += btnCloseDebtView_Click;
            // 
            // btnExportDebtView
            // 
            btnExportDebtView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnExportDebtView.Location = new Point(632, 415);
            btnExportDebtView.Name = "btnExportDebtView";
            btnExportDebtView.Size = new Size(75, 23);
            btnExportDebtView.TabIndex = 0;
            btnExportDebtView.Text = "Export";
            btnExportDebtView.UseVisualStyleBackColor = true;
            // 
            // DebtForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCloseDebtView);
            Controls.Add(btnExportDebtView);
            Controls.Add(dataGridViewDebts);
            Controls.Add(label1);
            Name = "DebtForm";
            Text = "List of Debts";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDebts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewDebts;
        private Button btnCloseDebtView;
        private Button btnExportDebtView;
    }
}