using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using SchoolManagement;

namespace SchoolManagementForm
{
    public partial class FrmMainWindow : Form
    {
        public FrmMainWindow()
        {
            InitializeComponent();
            // TODO: Find a way to cast
            // Storage storage = new Storage("./students.csv");
            // List<Student> students = storage.Load();
            // foreach (Student student in students)
            // {
            //     lstStudents.Items.Add(student);
            // }
        }

        private void showAddStudentWindow(object sender, EventArgs e)
        {
            FrmAddStudent childForm = new FrmAddStudent();
            if (childForm.ShowDialog() == DialogResult.OK)
            {
                lstStudents.Items.Add(childForm.Student);
                lstStudentsUpdate();
            }
        }

        private void removeSelectedStudent(object sender, EventArgs e)
        {
            lstStudents.Items.Remove(lstStudents.SelectedItem);
            lstStudentsUpdate();
        }

        private void editStudent(object sender, MouseEventArgs e)
        {
            if (lstStudents.SelectedItem != null)
            {
                FrmAddStudent childForm = new FrmAddStudent((Student)lstStudents.SelectedItem, false);
                if (childForm.ShowDialog() == DialogResult.OK)
                {
                    lstStudents.Items[lstStudents.SelectedIndex] = childForm.Student;
                    lstStudentsUpdate();
                }
            }
        }
        private void lstStudentsUpdate()
        {
            Storage storage = new Storage("./students.csv");
            storage.Save(lstStudents.Items.Cast<Object>().ToList());
        }
    }
}
