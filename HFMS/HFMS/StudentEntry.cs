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
    public partial class StudentEntry : UserControl
    {
        private HFMS_WINDOW window;
        private static StudentEntry inst;
        public static StudentEntry instance
        {
            get
            {
                if (inst == null)
                    inst = new StudentEntry();
                return inst;
            }


        }
        public StudentEntry()
        {
            InitializeComponent();
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length > 0)
            {
                Student student = new Student();
                student.FirstName = txtFirstName.Text;
                student.LastName = txtLastName.Text;
                student.RollNo = txtRollNo.Text;
                student.Ptype = 0;
                student.RoomNo = txtRoomNo.Text;
                student.Relation = txtRelation.Text;
                student.contact = txtContact.Text;
                student.Email = txtEmail.Text;
                student.GuardianName = txtGName.Text;
                student.GuardianEmail = txtGEmail.Text;
                student.GuardianContact = txtGContact.Text;
                //Persondb.RegisterNewStudent(student);
            }
            else
            {
                MessageBox.Show("Error Fill in Required Fields!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = txtLastName.Text = txtEmail.Text = txtContact.Text = txtCnic.Text = txtAddress.Text = txtGEmail.Text = txtGName.Text = txtGContact.Text = "";
            txtRelation.Text = txtRollNo.Text = txtRoomNo.Text = "";

        }

        private void StudentEntry_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!HFMS_WINDOW.MainPanel.Controls.Contains(Fine.instance))
            {
                HFMS_WINDOW.MainPanel.Controls.Add(Fine.instance);
                Fine.instance.BringToFront();
            }
            else
                Fine.instance.BringToFront();
        }
    }
}
