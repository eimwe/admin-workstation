namespace admin_workstation
{
    partial class CreateUpdateForm
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
            labelTitle = new Label();
            panel1 = new Panel();
            textBoxClientPhone = new TextBox();
            textBoxClientBirthDate = new TextBox();
            textBoxClientLastName = new TextBox();
            textBoxClientFirstName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            labelClientId = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(547, 24);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Create Client";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(textBoxClientPhone);
            panel1.Controls.Add(textBoxClientBirthDate);
            panel1.Controls.Add(textBoxClientLastName);
            panel1.Controls.Add(textBoxClientFirstName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(labelClientId);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(547, 296);
            panel1.TabIndex = 4;
            // 
            // textBoxClientPhone
            // 
            textBoxClientPhone.Location = new Point(132, 179);
            textBoxClientPhone.Name = "textBoxClientPhone";
            textBoxClientPhone.Size = new Size(378, 23);
            textBoxClientPhone.TabIndex = 10;
            // 
            // textBoxClientBirthDate
            // 
            textBoxClientBirthDate.Location = new Point(132, 140);
            textBoxClientBirthDate.Name = "textBoxClientBirthDate";
            textBoxClientBirthDate.Size = new Size(378, 23);
            textBoxClientBirthDate.TabIndex = 11;
            // 
            // textBoxClientLastName
            // 
            textBoxClientLastName.Location = new Point(132, 100);
            textBoxClientLastName.Name = "textBoxClientLastName";
            textBoxClientLastName.Size = new Size(378, 23);
            textBoxClientLastName.TabIndex = 12;
            // 
            // textBoxClientFirstName
            // 
            textBoxClientFirstName.Location = new Point(132, 63);
            textBoxClientFirstName.Name = "textBoxClientFirstName";
            textBoxClientFirstName.Size = new Size(378, 23);
            textBoxClientFirstName.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 182);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 6;
            label6.Text = "Phone Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 143);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 7;
            label5.Text = "Date of Birth:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 103);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 8;
            label4.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 66);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 9;
            label3.Text = "First Name:";
            // 
            // labelClientId
            // 
            labelClientId.AutoSize = true;
            labelClientId.Location = new Point(132, 32);
            labelClientId.Name = "labelClientId";
            labelClientId.Size = new Size(0, 15);
            labelClientId.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 5;
            label1.Text = "Client ID:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(435, 243);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(354, 243);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // CreateUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 344);
            Controls.Add(panel1);
            Controls.Add(labelTitle);
            Name = "CreateUpdateForm";
            Text = "Manage Client";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private Panel panel1;
        private Button btnSave;
        private Button btnCancel;
        private TextBox textBoxClientPhone;
        private TextBox textBoxClientBirthDate;
        private TextBox textBoxClientLastName;
        private TextBox textBoxClientFirstName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label labelClientId;
        private Label label1;
    }
}