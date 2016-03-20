using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HFMS.Controls;
namespace HFMS
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void forgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        public static String Warden
        {
            set;
            get;
        }
        public static String Admin
        {
            set;
            get;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string password = txtPassword.Text;
            string  []result = HFMS.Controls.Login.checkPassword(name,password);
            int re = 0;
            if (result != null)
            {
                if (result[0].Equals("NULL"))
                    re = 0;
                else if (result[0].Equals(password))
                    re = 1;
                else
                    re = 2;
                if (re == 1)
                {
                    HFMS.Controls.Login.updateStatus(name);
                    Login.Warden = name;
                    Login.Admin = result[1];
                    warden obj = new warden();

                    obj.Show();
                    this.Hide();
                }
                else
                {
                    txtName.Text = "";
                    txtPassword.Text = "";
                    txtName.Focus();
                    if (re == 0)
                        MessageBox.Show("User Name does not exist");
                    else
                        MessageBox.Show("Invalid Password");
                }
            }
            else
            {
             
                    MessageBox.Show("User Name does not exist");
            }
           
        }
    }
}
