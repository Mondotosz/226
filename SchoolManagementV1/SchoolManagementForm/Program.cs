using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagement;

namespace SchoolManagementForm
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            List<Student> students;
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainWindow());
        }
    }
}
