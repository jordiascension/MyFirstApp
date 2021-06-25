using System;
using System.Collections;
using System.Windows.Forms;

namespace MyFirstApp.ForeachLoop
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var student = new Student();
            student.StudentId = Convert.ToInt32(txtStudentId.Text);
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Age = Convert.ToInt32(txtAge.Text);

            var studentList = new ArrayList(); // recommended 
            //Boxing-Polymorphism
            studentList.Add(student);

            foreach (Student _student in studentList)
            {
                //Unboxing-Polymorphism
                MessageBox.Show(_student.Name +
                                 " " + _student.Surname);

            }
        }
    }
}
