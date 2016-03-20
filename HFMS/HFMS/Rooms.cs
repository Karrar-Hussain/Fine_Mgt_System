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
    public partial class Rooms : UserControl
    {
        ErrorProvider error = new ErrorProvider();
        Room room = new Room();
        bool check = false;  
       
        private static Rooms inst;
        public static Rooms instance
        {
            get
            {
                if (inst == null)
                    inst = new Rooms();
                return inst;
            }
        }
        public Rooms()
        {
            InitializeComponent();
           
            pnlUpdate.Parent = pnlInsert.Parent;
            pnlUpdate.Location = pnlInsert.Location;
            pnlUpdate.Size = pnlInsert.Size;
            pnlView.Parent = pnlInsert.Parent;
            pnlView.Location = pnlInsert.Location;
            pnlView.Size = pnlInsert.Size;

            //panel4.Visible = true;
            

        }

        private void button5_Click(object sender, EventArgs e)
        {

            pnlInsert.Visible = true;
            pnlUpdate.Visible = false;
            pnlView.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //InitializeComponent();
            beds.Visible = false;
            floorno.Visible = false;
            vcancy.Visible = false;
            txtbed.Visible = false;
            txtfloorno.Visible = false;
            txtvcancy.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;


            pnlInsert.Visible = false;
            pnlUpdate.Visible = true;
            pnlView.Visible = false;
        }

        private void grdRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            pnlInsert.Visible = false;
            pnlUpdate.Visible = false;
            pnlView.Visible = true;
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            pnlInsert.Visible = true;
            pnlUpdate.Visible = false;
            pnlView.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBeds.Text = "";
            txtVacancy.Text = "";
            txtFloorNumber.Text = "";
            
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = true;
                error.BlinkRate = 0;
                if (string.IsNullOrEmpty(txtBeds.Text) || (Convert.ToInt32(txtBeds.Text) < 3 || Convert.ToInt32(txtBeds.Text) > 10))
                {
                    error.SetError(txtBeds, "Range(3-10)");
                    check = false;
                }

                if (string.IsNullOrEmpty(txtVacancy.Text) || (Convert.ToInt32(txtVacancy.Text) < 0 || Convert.ToInt32(txtVacancy.Text) > Convert.ToInt32(txtBeds.Text)))
                {
                    error.SetError(txtVacancy, "Range(0-" + txtBeds.Text + ")");
                    check = false;
                }
                if (string.IsNullOrEmpty(txtFloorNumber.Text) || (Convert.ToInt32(txtFloorNumber.Text) < 1 || Convert.ToInt32(txtFloorNumber.Text) > 5))
                {
                    error.SetError(txtFloorNumber, "Range(1-5)");
                    check = false;
                }
                if (check)
                {
                    Room room = new Room();
                    room.Beds = Convert.ToInt32(txtBeds.Text);
                    room.FloorNo = Convert.ToInt32(txtFloorNumber.Text);
                    room.Vacancy = Convert.ToInt32(txtVacancy.Text);
                    Roomdb r = new Roomdb();
                    r.insert(room);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Missing Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void txtBeds_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtVacancy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtFloorNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtBeds_TextChanged(object sender, EventArgs e)
        {
            error.Clear();
        }

        private void txtVacancy_TextChanged(object sender, EventArgs e)
        {
            error.Clear();
        }

        private void txtFloorNumber_TextChanged(object sender, EventArgs e)
        {
            error.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                room.Id = Convert.ToInt32(txtSearch.Text);
                room.Beds = 0;
                room.FloorNo = 0;
                room.Vacancy = 0;
                Roomdb db = new Roomdb();
                if (db.search(ref room))
                {
                    if (room.Id > 0)
                    {
                        txtSearch.Text = "" + room.Id;
                        beds.Visible = true;
                        floorno.Visible = true;
                        vcancy.Visible = true;
                        txtbed.Visible = true;
                        txtbed.Text = "" + room.Beds;
                        txtfloorno.Visible = true;
                        txtfloorno.Text = "" + room.FloorNo;
                        txtvcancy.Visible = true;
                        txtvcancy.Text = "" + room.Vacancy;
                        btnUpdate.Visible = true;
                        btnDelete.Visible = true;
                        check = true;

                    }
                }
                else
                {
                    MessageBox.Show("No Record Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("ID Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (check)
            {
                Roomdb db = new Roomdb();
             //   room.Beds = Convert.ToInt32(txtbed.Text);
              //  room.FloorNo = Convert.ToInt32(txtfloorno.Text);
                //room.Vacancy = Convert.ToInt32(txtvcancy.Text);
                if (db.Delete(room))
                {
                    MessageBox.Show("Deleted", "Done");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (check)
            {
                Roomdb db = new Roomdb();
                room.Beds = Convert.ToInt32(txtbed.Text);
                room.FloorNo = Convert.ToInt32(txtfloorno.Text);
                room.Vacancy = Convert.ToInt32(txtvcancy.Text);
                if (db.Update(room))
                {
                    MessageBox.Show("Record Update", "Done");
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
