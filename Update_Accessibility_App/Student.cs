using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Update_Accessibility_App
{

  class Student
  {
    public Student(int studentNo, string studentName, string studentSex, int studentPhoneNum, string homeNumber, string student_habit, bool is_Student, int student_Count, int Lucky_number)
    {
      StudentNo = studentNo;
      StudentName = studentName;
      StudentSex = studentSex;
      StudentPhoneNum = studentPhoneNum;
      HomeNumber = homeNumber;
      Is_Student = is_Student;
      Student_habit = student_habit;
      Student_Count = student_Count;
      Lucky_Number = Lucky_number;
    }

    public Student(int studentNo, string studentName, string studentSex)
    {
      Id = studentNo;
      Name = studentName;
      Sex = studentSex;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Sex { get; set; }
    public string DisplayText => $"{Id} - {Name}";

    public int StudentNo { get; set; }
    public int Student_Count { get; set; }
    public int Lucky_Number { get; set; }
    public int StudentPhoneNum { get; set; }
    public string StudentName { get; set; }
    public string StudentSex { get; set; }
    public string HomeNumber { get; set; }
    public string Student_habit { get; set; }
    public bool Is_Student{ get; set; }
  }
}

