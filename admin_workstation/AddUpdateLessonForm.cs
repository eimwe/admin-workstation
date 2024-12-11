using admin_workstation.Models;
using admin_workstation.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin_workstation
{
    public partial class AddUpdateLessonForm : Form
    {
        public AddUpdateLessonForm()
        {
            InitializeComponent();
            LoadComboBoxData();
            this.DialogResult = DialogResult.Cancel;
        }

        private void LoadComboBoxData()
        {
            var clientRepo = new ClientRepository();
            var clients = clientRepo.GetClients();
            this.comboBoxLessonClients.DataSource = clients.Select(c => new { Value = c.id, Display = c.firstName + " " + c.lastName }).ToList();
            this.comboBoxLessonClients.DisplayMember = "Display";
            this.comboBoxLessonClients.ValueMember = "Value";

            var courseRepo = new CourseRepository();
            var courses = courseRepo.GetCourses();
            this.comboBoxLessonCourses.DataSource = courses.Select(c => new { Value = c.id, Display = c.title }).ToList();
            this.comboBoxLessonCourses.DisplayMember = "Display";
            this.comboBoxLessonCourses.ValueMember = "Value";

            var teacherRepo = new TeacherRepository();
            var teachers = teacherRepo.GetTeachers();
            this.comboBoxLessonTeachers.DataSource = teachers.Select(c => new { Value = c.id, Display = c.firstName + " " + c.lastName }).ToList();
            this.comboBoxLessonTeachers.DisplayMember = "Display";
            this.comboBoxLessonTeachers.ValueMember = "Value";

            var classroomRepo = new ClassroomRepository();
            var classrooms = classroomRepo.GetClassrooms();
            this.comboBoxLessonClassroom.DataSource = classrooms.Select(c => new { Value = c.id, Display = c.room }).ToList();
            this.comboBoxLessonClassroom.DisplayMember = "Display";
            this.comboBoxLessonClassroom.ValueMember = "Value";
        }

        private void btnSavePayment_Click(object sender, EventArgs e)
        {
            Lesson lesson = new Lesson();
            lesson.id = 0;
            lesson.clientId = (int)((dynamic)this.comboBoxLessonClients.SelectedItem).Value;
            lesson.courseId = (int)((dynamic)this.comboBoxLessonCourses.SelectedItem).Value;
            lesson.teacherId = (int)((dynamic)this.comboBoxLessonTeachers.SelectedItem).Value;
            lesson.classroomId = (int)((dynamic)this.comboBoxLessonClassroom.SelectedItem).Value;
            lesson.lessonDate = this.dateTimePickerLesson.Value;

            var repo = new LessonRepository();
            repo.AddLesson(lesson);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelPayment_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
