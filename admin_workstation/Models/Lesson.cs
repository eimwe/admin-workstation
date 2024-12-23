using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_workstation.Models
{
    public class Lesson
    {
        public int id;
        public int clientId;
        public string clientName = "";
        public int courseId;
        public string courseTitle = "";
        public int teacherId;
        public string teacherName = "";
        public int classroomId;
        public string classroomNumber = "";
        public DateTime lessonDate = DateTime.Now;
        public TimeSlot timeSlot = TimeSlot.Slot_10_11;
    }
}
