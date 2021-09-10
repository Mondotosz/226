using System;
using System.Collections.Generic;
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
    }
}
