using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationForm
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            string username = "donnlingo";
            string pass = "123456";
            
            var openEIForm = new employeeinformationForm();
            var openInvalidForm = new invalidForm();

            if (username == userBox.Text) { 
            
                if (pass == passBox.Text)
                {
                    openEIForm.ShowDialog();

                }

                else {

                    openInvalidForm.ShowDialog();
                }
            }

            else
            {
                openInvalidForm.ShowDialog();
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            userBox.Clear();
            passBox.Clear();
        }
    }
}
