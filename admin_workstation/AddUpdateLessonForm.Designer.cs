namespace admin_workstation
{
    partial class AddUpdateLessonForm
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
            labelLessonTitle = new Label();
            panel1 = new Panel();
            btnSavePayment = new Button();
            btnCancelPayment = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBoxLessonCourses = new ComboBox();
            comboBoxLessonClients = new ComboBox();
            dateTimePickerLesson = new DateTimePicker();
            comboBoxLessonTeachers = new ComboBox();
            comboBoxLessonClassroom = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelLessonTitle
            // 
            labelLessonTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelLessonTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLessonTitle.Location = new Point(12, 9);
            labelLessonTitle.Name = "labelLessonTitle";
            labelLessonTitle.Size = new Size(403, 24);
            labelLessonTitle.TabIndex = 1;
            labelLessonTitle.Text = "Add Lesson";
            labelLessonTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnSavePayment);
            panel1.Controls.Add(btnCancelPayment);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxLessonClassroom);
            panel1.Controls.Add(comboBoxLessonTeachers);
            panel1.Controls.Add(comboBoxLessonCourses);
            panel1.Controls.Add(comboBoxLessonClients);
            panel1.Controls.Add(dateTimePickerLesson);
            panel1.Location = new Point(12, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 250);
            panel1.TabIndex = 2;
            // 
            // btnSavePayment
            // 
            btnSavePayment.Location = new Point(197, 201);
            btnSavePayment.Name = "btnSavePayment";
            btnSavePayment.Size = new Size(75, 23);
            btnSavePayment.TabIndex = 5;
            btnSavePayment.Text = "Save";
            btnSavePayment.UseVisualStyleBackColor = true;
            // 
            // btnCancelPayment
            // 
            btnCancelPayment.Location = new Point(278, 201);
            btnCancelPayment.Name = "btnCancelPayment";
            btnCancelPayment.Size = new Size(75, 23);
            btnCancelPayment.TabIndex = 6;
            btnCancelPayment.Text = "Cancel";
            btnCancelPayment.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 152);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 3;
            label5.Text = "Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 93);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "Teacher:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 64);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 3;
            label3.Text = "Course:";
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
            // comboBoxLessonCourses
            // 
            comboBoxLessonCourses.FormattingEnabled = true;
            comboBoxLessonCourses.Location = new Point(105, 61);
            comboBoxLessonCourses.Name = "comboBoxLessonCourses";
            comboBoxLessonCourses.Size = new Size(249, 23);
            comboBoxLessonCourses.TabIndex = 2;
            // 
            // comboBoxLessonClients
            // 
            comboBoxLessonClients.FormattingEnabled = true;
            comboBoxLessonClients.Location = new Point(105, 32);
            comboBoxLessonClients.Name = "comboBoxLessonClients";
            comboBoxLessonClients.Size = new Size(249, 23);
            comboBoxLessonClients.TabIndex = 1;
            // 
            // dateTimePickerLesson
            // 
            dateTimePickerLesson.Location = new Point(105, 148);
            dateTimePickerLesson.Name = "dateTimePickerLesson";
            dateTimePickerLesson.Size = new Size(249, 23);
            dateTimePickerLesson.TabIndex = 4;
            // 
            // comboBoxLessonTeachers
            // 
            comboBoxLessonTeachers.FormattingEnabled = true;
            comboBoxLessonTeachers.Location = new Point(105, 90);
            comboBoxLessonTeachers.Name = "comboBoxLessonTeachers";
            comboBoxLessonTeachers.Size = new Size(249, 23);
            comboBoxLessonTeachers.TabIndex = 2;
            // 
            // comboBoxLessonClassroom
            // 
            comboBoxLessonClassroom.FormattingEnabled = true;
            comboBoxLessonClassroom.Location = new Point(105, 119);
            comboBoxLessonClassroom.Name = "comboBoxLessonClassroom";
            comboBoxLessonClassroom.Size = new Size(249, 23);
            comboBoxLessonClassroom.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 122);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 3;
            label1.Text = "Classroom:";
            // 
            // AddUpdateLessonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 297);
            Controls.Add(panel1);
            Controls.Add(labelLessonTitle);
            Name = "AddUpdateLessonForm";
            Text = "Add Lesson";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelLessonTitle;
        private Panel panel1;
        private Button btnSavePayment;
        private Button btnCancelPayment;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxLessonCourses;
        private ComboBox comboBoxLessonClients;
        private DateTimePicker dateTimePickerLesson;
        private Label label1;
        private ComboBox comboBoxLessonClassroom;
        private ComboBox comboBoxLessonTeachers;
    }
}