using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HFMS.model;

namespace HFMS
{
    public partial class AdminControl : UserControl
    {

        private static AdminControl inst;
        public static AdminControl instance
        {
            get
            {
                if (inst == null)
                    inst = new AdminControl();
                return inst;
            }
        }
        public AdminControl()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Warden obj = new Warden();
            obj.Ptype = 0;
            obj.FirstName = txtFirstName.Text;
            obj.LastName = txtLastName.Text;
            obj.LoginId = txtLoginId.Text;
            obj.CNIC = txtCnic.Text;
            obj.RoomNo = txtRoomNo.Text;
            obj.Email = txtEmail.Text;
            obj.Address = txtAddress.Text;
            obj.contact = txtContact.Text;
            obj.Designation = txtDesign.Text;
            obj.OfficeLocation = txtOffLoc.Text;
            obj.Password=txtPassword.Text;
            int result = Wardendb.addWarden(obj);
            if (result > 0)
            {
                pnlAdd.Visible = false;
                MessageBox.Show("Done Successfully.");
            }
            else
            {
                pnlAdd.Refresh();
                MessageBox.Show("Error Occured.");
            }
        
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAdd.Refresh();
            
        }
    }
}
