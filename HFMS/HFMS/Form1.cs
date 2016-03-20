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
    public partial class NewStudentForm : Form
    {
        public NewStudentForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length != 0)
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
                //Model.RegisterNewStudent(student);
            }
            else
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = txtLastName.Text = txtEmail.Text = txtContact.Text = txtCnic.Text = txtAddress.Text = txtGEmail.Text = txtGName.Text = txtGContact.Text = "";
            txtRelation.Text = txtRollNo.Text = txtRoomNo.Text = "";
        }

        private void lblRelation_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
