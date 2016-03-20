using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFMS
{
    public partial class MyAccount : UserControl
    {
        public MyAccount()
        {
            InitializeComponent();
            pnlloginID.Parent = pnlPassword.Parent;
            pnlloginID.Location = pnlPassword.Location;
            pnlOffice.Parent = pnlPassword.Parent;
            pnlOffice.Location = pnlPassword.Location;
            panel2.Size = new Size(200, 446);
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {
            pnlloginID.Visible = false;
            pnlPassword.Visible = false;
            pnlOffice.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = HFMS.Controls.Login.currentLoginID();
            curentID1.Text = result;
            pnlOffice.Visible = false;
            pnlPassword.Visible = false;
            pnlloginID.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = HFMS.Controls.Login.currentLoginID();
            CurrentID.Text = result;
            pnlOffice.Visible = false;
            pnlloginID.Visible = false;
            pnlPassword.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool result = HFMS.Controls.Login.updateLoginID(curentID1.Text, txtlogin.Text);
            if (result == true)
            {
                MessageBox.Show("Login ID Changed Successfully.");
                pnlloginID.Visible = false;
                pnlPassword.Visible = false;
                pnlOffice.Visible = false;
            }
            else
            {
                MessageBox.Show("Error Occured");
                txtlogin.Text = "";
                txtReLogin.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool result = HFMS.Controls.Login.updatePassword(curentID1.Text, txtPassword.Text);
            if (result == true)
            {
                MessageBox.Show("Password Changed Successfully.");
                pnlPassword.Visible = false;
                pnlOffice.Visible = false;
                pnlloginID.Visible = false;

            }
            else
            {
                MessageBox.Show("Error Occured");
                txtPassword.Text = "";
                txtRePassword.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool result = HFMS.Controls.Login.updateOffice(curid.Text, txtOffice.Text);
            if (result == true)
            {
                MessageBox.Show("Office Changed Successfully.");
                pnlloginID.Visible = false;
                pnlOffice.Visible = false;
                pnlPassword.Visible = false;
            }
            else
            {
                MessageBox.Show("Error Occured");
                txtOffice.Text = "";
                txtReOffice.Text = "";
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string result = HFMS.Controls.Login.currentLoginID();
            curid.Text = result;
            pnlOffice.Visible = true;
            pnlPassword.Visible = false;
            pnlloginID.Visible = false;
        }
       
    }
}
