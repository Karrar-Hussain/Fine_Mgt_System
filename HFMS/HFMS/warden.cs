using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFMS
{
    public partial class warden : Form
    {
        StudentControl sc = new StudentControl();
        MyAccount myAccount = new MyAccount();
        public warden()
        {
            InitializeComponent();
            //this.myAccount1.Hide();
        }

        private void warden_Load(object sender, EventArgs e)
        {

            if(Login.Admin != "admin")
            {
                btnWarden.Hide();
            }
            else
            {
                btnFine.Hide();
            }
            this.Controls.Add(myAccount);
            this.Controls.Add(sc);
            myAccount.BringToFront();
            myAccount.Location = new Point(0, 134);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Dispose();
            login.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
      

        private void pnlloginID_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CurrentID_Click(object sender, EventArgs e)
        {

        }

        private void myAccount1_Load(object sender, EventArgs e)
        {

        }

        private void btnFine_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(Fine.instance))
            {
                Fine.instance.Location = new Point(0, 134);
                this.Controls.Add(Fine.instance);
                Fine.instance.BringToFront();
            }
            else
                Fine.instance.BringToFront();

        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(Rooms.instance))
            {
                Rooms.instance.Location = new Point(0, 134);
                this.Controls.Add(Rooms.instance);
                Rooms.instance.BringToFront();
            }
            else
                Rooms.instance.BringToFront();

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            myAccount.BringToFront();
            myAccount.Location = new Point(0, 134);
            myAccount.Visible = true;
            sc.Visible = false;
        
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            sc.BringToFront();
            sc.Location = new Point(0, 134);
            myAccount.Visible = false;
            sc.Visible = true;
        }

        private void btnWarden_Click(object sender, EventArgs e)
        {

            if (!this.Controls.Contains(AdminControl.instance))
            {
                AdminControl.instance.Location = new Point(0, 134);
                this.Controls.Add(AdminControl.instance);
                AdminControl.instance.BringToFront();
            }
            else
                AdminControl.instance.BringToFront();

        }
    }
}
