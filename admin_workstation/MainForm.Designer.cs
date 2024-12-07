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
            tabControlTables.SuspendLayout();
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
            tabPageClients.Location = new Point(4, 30);
            tabPageClients.Name = "tabPageClients";
            tabPageClients.Padding = new Padding(3);
            tabPageClients.Size = new Size(768, 392);
            tabPageClients.TabIndex = 0;
            tabPageClients.Text = "Clients";
            tabPageClients.UseVisualStyleBackColor = true;
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
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlTables;
        private TabPage tabPageClients;
    }
}