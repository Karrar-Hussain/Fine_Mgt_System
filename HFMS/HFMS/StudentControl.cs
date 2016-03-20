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
    public partial class StudentControl : UserControl
    {
        ErrorProvider error = new ErrorProvider();
        
        public StudentControl()
        {
            InitializeComponent();
            txtroll.LostFocus += txtroll_LostFocus;
            pnlSearch.Parent = pnlAdd.Parent;
            pnlSearch.Location = pnlAdd.Location;
            pnlUpdate.Parent = pnlAdd.Parent;
            pnlUpdate.Location = pnlAdd.Location;
            pnlDelete.Parent = pnlAdd.Parent;
            pnlDelete.Location = pnlAdd.Location;
        }

        private void StudentControl_Load(object sender, EventArgs e)
        {
            pnlSearch.Visible = false;

            pnlUpdate.Visible = false;
            pnlAdd.Visible = false;
            pnlDelete.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            HFMS.Controls.StudentController Add = new HFMS.Controls.StudentController();
            Student obj = new Student();
            obj.Ptype = 0;
            obj.FirstName=txtFirstName.Text;
            obj.LastName = txtLastName.Text;
            obj.RollNo = txtRollNo.Text;
            obj.CNIC = txtCnic.Text;
            obj.RoomNo = txtRoomNo.Text;
            obj.Email = txtEmail.Text;
            obj.Address = txtAddress.Text;
            obj.contact = txtContact.Text;
            obj.GuardianName = txtGName.Text;
            obj.GuardianEmail = txtGEmail.Text;
            obj.GuardianContact = txtGContact.Text;
            obj.Relation = txtRelation.Text;
            int result = Add.addStudent(obj);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAdd.Refresh();
            pnlAdd.Visible = false;
        }

        private void add_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = false;
            pnlUpdate.Visible = false;
            pnlAdd.Visible = true;
            pnlDelete.Visible = false;
        }

        private void update_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = false;
            pnlUpdate.Visible = true;
            pnlAdd.Visible = false;
            pnlDelete.Visible = false;
        }

        private void btnSaveupdate_Click(object sender, EventArgs e)
        {
            HFMS.Controls.StudentController update = new HFMS.Controls.StudentController();
            Student obj = new Student();
            obj.Ptype = 0;
            obj.FirstName = txtname.Text;
            error.BlinkRate = 0;
            if (string.IsNullOrEmpty(txtname.Text) )
            {
                error.SetError(txtname, "");
                //check = false;
            
            obj.LastName = txtlname.Text;
            obj.RollNo = txtroll.Text;
            obj.CNIC = txtnic.Text;
            obj.RoomNo = txtroom.Text;
            obj.Email = txtemaill.Text;
            obj.Address = txtadd.Text;
            obj.contact = txtcontactno.Text;
            obj.GuardianName = txtgnamee.Text;
            obj.GuardianEmail = txtgemaill.Text;
            obj.GuardianContact = txtgcontactt.Text;
            obj.Relation = txtrelationn.Text;
            int result = update.updateStudent(obj);
            if (result > 0)
            {
                pnlUpdate.Visible = false;
                MessageBox.Show("Done Successfully.");
            }
            else
            {
                pnlUpdate.Refresh();
                MessageBox.Show("Error Occured.");
            }
            }
        }
        private void txtroll_LostFocus(object sender,EventArgs e)
        {
            HFMS.Controls.StudentController obj = new Controls.StudentController();
            if (txtroll.Text != null)
            {
                Student st = obj.getStudent(txtroll.Text);
                txtname.Text = st.FirstName;
                txtlname.Text = st.LastName;
                txtroll.Text = st.RollNo;
                txtnic.Text = st.CNIC;
                txtcontactno.Text = st.contact;
                txtemaill.Text = st.Email;
                txtgnamee.Text = st.GuardianName;
                txtgcontactt.Text = st.GuardianContact;
                txtgemaill.Text = st.GuardianEmail;
                txtadd.Text = st.Address;
                txtrelationn.Text = st.Relation;
                txtroom.Text = st.RoomNo;
            }
            
        }

        private void btncancelupdate_Click(object sender, EventArgs e)
        {
            pnlUpdate.Refresh();
            pnlUpdate.Visible = false;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = false;
            pnlAdd.Visible = false;
            pnlUpdate.Visible = false;
            pnlDelete.Visible = true;
        }

        private void pnlDelete_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;
            HFMS.Controls.StudentController obj = new Controls.StudentController();
            
            result = obj.deleteStudent(txtdel.Text);
            if (result > 0)
            {
                pnlDelete.Visible = false;
                MessageBox.Show("Done Successfully.");
            }
            else
            {
                pnlDelete.Refresh();
                MessageBox.Show("Error Occured.");
            
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {    
            pnlAdd.Visible = false;
            pnlDelete.Visible = false;
            pnlUpdate.Visible = false;
            pnlSearch.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pnlSearch_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
