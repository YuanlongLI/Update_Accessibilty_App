using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Update_Accessibility_App
{
    class Textbox_Class
    {
        public Textbox_Class(int studentNo, string studentName, string studentSex)
        {
            StudentNo = studentNo;
            StudentName = studentName;
            StudentSex = studentSex;
        }

        public int StudentNo { get; set; }
        public string StudentName { get; set; }
        public string StudentSex { get; set; }
    }
}
