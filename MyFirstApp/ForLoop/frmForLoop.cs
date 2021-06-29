using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

using MyFirstApp.ForeachLoop;

namespace MyFirstApp.ForLoop
{
    public partial class frmForLoop : Form
    {
        public frmForLoop()
        {
            InitializeComponent();
        }

        private void frmForLoop_Load(object sender, EventArgs e)
        {
            String sAttr = ConfigurationManager.AppSettings.Get("CsvFile");
            MessageBox.Show(sAttr);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var student = new Student();
            student.StudentId = Convert.ToInt32(txtStudentId.Text);
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Age = Convert.ToInt32(txtAge.Text);

            //Generic collections
            List<Student> studentList = new List<Student>(); // recommended 

            studentList.Add(student);

            for (int i = 0; i < studentList.Count; i++)
            {
                //Unboxing-Polymorphism
                MessageBox.Show(studentList[i].Name +
                                 " " + studentList[i].Surname);
            }
        }
    }
}
