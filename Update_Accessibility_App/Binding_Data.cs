using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Update_Accessibility_App
{
    public partial class Binding_Data : Form
    {
        List<Student> personA = new List<Student>();
        List<Student> personB = new List<Student>();
        List<Student> personC = new List<Student>();
        List<Student> personD = new List<Student>();
        public Binding_Data()
        {
            InitializeComponent();
            
        }

        private void Binding_Data_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 6; i++)
            {
               personA.Add(new Student(i, "Name 1"  + i, "Male"));
               personB.Add(new Student(i *2, "Name 11" + i *2, "Female"));
               personC.Add(new Student(i *3, "Name 12" + i *3, "Male"));
               personD.Add(new Student(i *4, "Name 14" + i *4, "Female"));
            }

            // Binding Data For ListBox & ComboBox controls
            listBox1.DataSource = personA;
            comboBox1.DataSource = personB;
            comboBox2.DataSource = personC;
            comboBox3.DataSource = personD;

            listBox1.DisplayMember = "Name";
            comboBox1.DisplayMember = "Name";
            comboBox2.DisplayMember = "Name";
            comboBox3.DisplayMember = "Name";

            // Binding Data For DataGridView control
            dataGridView1.DataSource = new List<Student>
             {
             new Student(24,"A",  "Male"),
             new Student(23, "B","Female"),
             new Student(22,"C", "Male"),
             new Student(21,"D","Female"),
            };


      //Binding Data For TextBox/Label control/DomianUpDown/NumericUpDown/LinkLabel/CheckBox/RadioButton/RichTextBox/MaskedTextBox/Button 
      Student stu = new Student(1, "StudentNumber", "Female", 12121, "PhoneNUmber","Basketball"+ '\n'+ "Football",true, 10, 11);
            this.textBox1.DataBindings.Add("Text", stu, "StudentNo");
            this.domainUpDown1.DataBindings.Add("Text", stu, "Lucky_Number");
            this.numericUpDown1.DataBindings.Add("Text", stu, "Student_Count");
            this.label1.DataBindings.Add("Text", stu, "StudentName");
            this.button1.DataBindings.Add("Text", stu, "StudentSex");
            this.maskedTextBox1.DataBindings.Add("Text", stu, "StudentPhoneNum");
            this.linkLabel1.DataBindings.Add("Text", stu, "HomeNumber");
            this.richTextBox1.DataBindings.Add("Text", stu, "Student_habit");
            this.checkBox1.DataBindings.Add("Checked", stu, "Is_Student");
            this.radioButton1.DataBindings.Add("Checked", stu, "Is_Student");
    }
    }
}
