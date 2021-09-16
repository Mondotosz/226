using System;
using System.Windows.Forms;
using SchoolManagement;

namespace SchoolManagementForm
{
    public partial class FrmAddStudent : Form
    {
        private Student _student;
        public Student Student
        {
            get => _student;
        }
        public FrmAddStudent()
        {
            InitializeComponent();
        }

        public FrmAddStudent(Student student){
            InitializeComponent();
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtClassName.Text = student.ClassName;
        }

        private void AddStudent(object sender, EventArgs e)
        {
            try
            {
                _student = new Student(txtFirstName.Text ?? "", txtLastName.Text ?? "", txtClassName.Text ?? "");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exception)
            {
                if(exception is BadFirstNameException) MessageBox.Show("Firstname requires an uppercase for the first letter","error");
                if(exception is BadClassNameException) MessageBox.Show("Class name doesn't respect naming conventions","error");
            }
        }

        private void Cancel(object sender, EventArgs e){
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
