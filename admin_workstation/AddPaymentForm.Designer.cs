namespace admin_workstation
{
    partial class AddPaymentForm
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
            panel1 = new Panel();
            label1 = new Label();
            dateTimePickerPayment = new DateTimePicker();
            comboBoxClients = new ComboBox();
            comboBoxCourses = new ComboBox();
            textBoxPayAmount = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCancelPayment = new Button();
            btnSavePayment = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnSavePayment);
            panel1.Controls.Add(btnCancelPayment);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxPayAmount);
            panel1.Controls.Add(comboBoxCourses);
            panel1.Controls.Add(comboBoxClients);
            panel1.Controls.Add(dateTimePickerPayment);
            panel1.Location = new Point(12, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 269);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(403, 23);
            label1.TabIndex = 1;
            label1.Text = "Add Payment";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dateTimePickerPayment
            // 
            dateTimePickerPayment.Location = new Point(105, 164);
            dateTimePickerPayment.Name = "dateTimePickerPayment";
            dateTimePickerPayment.Size = new Size(249, 23);
            dateTimePickerPayment.TabIndex = 4;
            // 
            // comboBoxClients
            // 
            comboBoxClients.FormattingEnabled = true;
            comboBoxClients.Location = new Point(105, 32);
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size(249, 23);
            comboBoxClients.TabIndex = 1;
            // 
            // comboBoxCourses
            // 
            comboBoxCourses.FormattingEnabled = true;
            comboBoxCourses.Location = new Point(105, 81);
            comboBoxCourses.Name = "comboBoxCourses";
            comboBoxCourses.Size = new Size(249, 23);
            comboBoxCourses.TabIndex = 2;
            // 
            // textBoxPayAmount
            // 
            textBoxPayAmount.Location = new Point(105, 125);
            textBoxPayAmount.Name = "textBoxPayAmount";
            textBoxPayAmount.Size = new Size(249, 23);
            textBoxPayAmount.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 35);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Client:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 84);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 3;
            label3.Text = "Course:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 128);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Amount:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 170);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 3;
            label5.Text = "Date:";
            // 
            // btnCancelPayment
            // 
            btnCancelPayment.Location = new Point(279, 217);
            btnCancelPayment.Name = "btnCancelPayment";
            btnCancelPayment.Size = new Size(75, 23);
            btnCancelPayment.TabIndex = 6;
            btnCancelPayment.Text = "Cancel";
            btnCancelPayment.UseVisualStyleBackColor = true;
            // 
            // btnSavePayment
            // 
            btnSavePayment.Location = new Point(198, 217);
            btnSavePayment.Name = "btnSavePayment";
            btnSavePayment.Size = new Size(75, 23);
            btnSavePayment.TabIndex = 5;
            btnSavePayment.Text = "Save";
            btnSavePayment.UseVisualStyleBackColor = true;
            // 
            // AddPaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 316);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "AddPaymentForm";
            Text = "Add Payment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxPayAmount;
        private ComboBox comboBoxCourses;
        private ComboBox comboBoxClients;
        private DateTimePicker dateTimePickerPayment;
        private Button btnSavePayment;
        private Button btnCancelPayment;
    }
}