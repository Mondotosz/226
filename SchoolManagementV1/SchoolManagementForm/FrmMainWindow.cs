using System;
using System.Windows.Forms;
using SchoolManagement;

namespace SchoolManagementForm
{
    public partial class FrmMainWindow : Form
    {
        public FrmMainWindow()
        {
            InitializeComponent();
        }

        private void showAddStudentWindow(object sender, EventArgs e)
        {
            FrmAddStudent childForm = new FrmAddStudent();
            childForm.ShowDialog();
            if (childForm.DialogResult == DialogResult.OK)
            {
                lstStudents.Items.Add(childForm.Student);
            }
        }

        private void removeSelectedStudent(object sender, EventArgs e)
        {

            lstStudents.Items.Remove(lstStudents.SelectedItem);

        }

        private void editStudent(object sender, MouseEventArgs e)
        {
            if (lstStudents.SelectedItem != null)
            {
                FrmAddStudent childForm = new FrmAddStudent((Student)lstStudents.SelectedItem);
                childForm.ShowDialog();
                if (childForm.DialogResult == DialogResult.OK)
                {
                    lstStudents.Items[lstStudents.SelectedIndex] = childForm.Student;
                }
            }
        }
    }
}
