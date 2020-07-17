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
        List<ComboBox_People> persons = new List<ComboBox_People>();
        List<ComboBox_People> person1 = new List<ComboBox_People>();
        List<ComboBox_People> person2 = new List<ComboBox_People>();
        List<ComboBox_People> person3 = new List<ComboBox_People>();
        public Binding_Data()
        {
            InitializeComponent();
            
        }

        private void Binding_Data_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 6; i++)
            {
               persons.Add(new ComboBox_People(i, "Name 1"  + i));
               person1.Add(new ComboBox_People(i *2, "Name 11" + i *2));
               person2.Add(new ComboBox_People(i *3, "Name 12" + i *3));
               person3.Add(new ComboBox_People(i *4, "Name 14" + i *4));
            }

            // Binding Data For ListBox & ComboBox controls
            listBox1.DataSource = persons;
            comboBox1.DataSource = person1;
            comboBox2.DataSource = person2;
            comboBox3.DataSource = person3;

            listBox1.DisplayMember = "Name";
            comboBox1.DisplayMember = "Name";
            comboBox2.DisplayMember = "Name";
            comboBox3.DisplayMember = "Name";

            // Binding Data For DataGridView control
            dataGridView1.DataSource = new List<DataGridView_Class>
             {
             new DataGridView_Class("A", 24, "Male"),
             new DataGridView_Class("B",23, "Female"),
             new DataGridView_Class("C",22, "Male"),
             new DataGridView_Class("D",21,"Female"),
            };


            //Binding Data For TextBox & Label control
            Textbox_Class stu = new Textbox_Class(123456, "Number2", "Female");
            this.textBox1.DataBindings.Add("Text", stu, "StudentNo");
            this.textBox2.DataBindings.Add("Text", stu, "StudentName");
            this.textBox3.DataBindings.Add("Text", stu, "StudentSex");

            Textbox_Class stu3 = new Textbox_Class(123456, "Number3", "Female");
            this.label1.DataBindings.Add("Text", stu3, "StudentNo");
            this.label2.DataBindings.Add("Text", stu3, "StudentName");
            this.label3.DataBindings.Add("Text", stu3, "StudentSex");

            
        }
    }
}
