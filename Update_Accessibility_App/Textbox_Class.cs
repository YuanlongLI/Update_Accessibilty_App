using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Update_Accessibility_App
{
    class Textbox_Class
    {
        public Textbox_Class(int studentNo, string studentName, string studentSex, int studentPhoneNum, string phoneNumber, string student_habit, bool student_flag, int student_numeric, int student_domin)
        {
            StudentNo = studentNo;
            StudentName = studentName;
            StudentSex = studentSex;
            StudentPhoneNum = studentPhoneNum;
            PhoneNumber = phoneNumber;
            Student_Flag = student_flag;
            Student_habit = student_habit;
            Student_numeric = student_numeric;
            Student_domin = student_domin;
        }

        public int StudentNo { get; set; }
        public int Student_numeric { get; set; }
        public int Student_domin { get; set; }
        public int StudentPhoneNum { get; set; }
        public string StudentName { get; set; }
        public string StudentSex { get; set; }
        public string PhoneNumber { get; set; }
        public string Student_habit { get; set; }
        public bool Student_Flag { get; set; }


  }
}
