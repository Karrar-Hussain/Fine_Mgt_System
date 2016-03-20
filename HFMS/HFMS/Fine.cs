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
using GSMCommDemo;
using HFMS.Controllers;

namespace HFMS
{
    public partial class Fine : UserControl
    {
        private static Fine inst;
        public static Fine instance
        {
            get {
                if (inst == null)
                {
                    inst = new Fine();

                }
                return inst;
            }
        }
        public Fine()
        {
            InitializeComponent();

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if(txtRollNo.Text.Length>0)
            {
                FineRecord fr = new FineRecord();
                fr.RollNo = txtRollNo.Text;
                fr.FineDate = DateTime.Now;

                fr.Amount = Convert.ToInt32(txtFineAmount.Text);
                fr.Charges = 5;
                fr.DueDate = DateTime.Now.AddDays(Convert.ToInt32(txtDueDays.Text));
                fr.FineDetail = txtDetail.Text;
                FineRecorddb frdb = new FineRecorddb();
                if(frdb.EnterFineRecord(fr))
                {
                    MessageBox.Show("New Record Entry Done!");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            txtDetail.Text = txtDueDays.Text = txtFineAmount.Text = txtRollNo.Text = "";
        }

        private void txtFineAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fine_Load(object sender, EventArgs e)
        {
            
            paneView.Parent = paneAddFine.Parent;
            paneCollectFine.Parent = paneAddFine.Parent;
            paneCollectFine.Location = paneAddFine.Location;
            paneView.Location = paneAddFine.Location;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmConnection con = new frmConnection();
            con.ShowDialog();
            con.GetPort();
            //frmDemo demo = new frmDemo();
            //demo.ShowDialog();
            sendSMS sndsms = new sendSMS();
            FineRecorddb db = new FineRecorddb();
            string contact=db.GetGContact(txtRollNo.Text);
            string[] com = { "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8" };
            //MessageBox.Show(contact);
            string comNum = "0";
            //contact = "+923336374591";
            for(int i=0;i<8;i++)
            {
              
                if(sndsms.SetCOMNum(com[i]))
                {
                    comNum = com[i];
                }
            }
            if (contact!="0")
            {
                string msg= "Fine Amount:"+txtFineAmount.Text;
                msg += "\nFine Detail:" + txtDetail;
                sndsms.SetCOMNum(comNum);
                sndsms.Sendsms(msg, contact);
            }
            else
            {
                MessageBox.Show("Error No Guardian Contact number or invalid!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Amount(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            paneAddFine.BringToFront();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtRollNo2.Text.Length > 0)
            {
                string rollno = txtRollNo2.Text;
                FineRecorddb frdb = new FineRecorddb();
                FineRecord fr;
                fr = frdb.SearchFine(rollno);
                if (fr != null)
                {
                    txtAmount2.Text = fr.Amount + "";
                    txtDueDate.Text = fr.DueDate.ToString();
                    txtFineDetail2.Text = fr.FineDetail;
                }
            }else
            {
                MessageBox.Show("Student Has No Fine on his Head!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtFineDetail2.Text = txtDueDate.Text = txtAmount2.Text = txtRollNo2.Text = "";
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.fineRecordTblTableAdapter.FillBy(this.hFMS_dbDataSet.FineRecordTbl);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lblFineAmount_Click(object sender, EventArgs e)
        {

        }

        private void sidePane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewFines_Click(object sender, EventArgs e)
        {
            FineRecorddb db=new FineRecorddb();
            DataSet ds = db.AllPendingFines();
            dataGridView1.DataSource = ds;
            
            paneView.BringToFront();
        }

        private void btnCollectFine_Click(object sender, EventArgs e)
        {
            paneCollectFine.BringToFront();
        }
        private void btnCollect_Click(object sender, EventArgs e)
        {
            paneCollectFine.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FineRecorddb db = new FineRecorddb();
            if(db.sendMail(txtRollNo.Text, txtFineDetail2.Text))
            {
                MessageBox.Show("Email Sent Successfully!");
            }
            else
            {
                MessageBox.Show("Email Not Sent! Problem with Connection!");
            }

        }
    }
}
