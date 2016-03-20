using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using HFMS.Controls;
using System.Windows.Forms;
using System.Data;
using HFMS.Controllers;

namespace HFMS.model
{
    class FineRecorddb
    {
        private SqlConnection connection;
        private String ConStr = ConfigurationSettings.AppSettings["ConStr"];

        public FineRecorddb()
        {
            connection = new SqlConnection(ConStr);
        }
        public bool PayFine(string rollno)
        {
            connection.Open();
            bool bol = false;
            SqlCommand cmd = new SqlCommand("update FineRecordTbl set IsPaid = \'" + 1 + "\' where RollNo = \'" + rollno + "\' ", connection);
            if (cmd.ExecuteNonQuery() > 0)
            {
                bol = true;
            }
            connection.Close();
            return bol;
        }
        public DataSet AllPendingFines()
        {
            connection.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select * From FineRecordTbl ", connection);
            da.Fill(ds);
            connection.Close();
            return ds;
             
        }
        public FineRecord SearchFine(string rollno)
        {
            connection.Open();
            FineRecord fr = null;
            SqlCommand cmd = new SqlCommand("Select * From FineRecordTbl where StudentId = ( select Id FROM StudentTbl where RollNo = \'" + rollno + "\' ) ", connection);
            using (SqlDataReader read = cmd.ExecuteReader())
            {
                if (read.Read())
                {
                    fr = new FineRecord();
                    fr.Amount = (int)read["Amount"];
                    fr.FineDetail = (string)read["FineDetail"];
                    fr.DueDate = (DateTime)read["DueDate"];
                }
                else
                    MessageBox.Show("No Fine on this Student's Head!");
            }
            connection.Close();
            return fr;
        }
        public bool sendMail (string rollno,string finedetail)
        {
            connection = new SqlConnection(ConStr);
            connection.Open();
            SendMail sndml = new SendMail();
            string email = "0";
            string gemail = "0";
            FineRecord fr = null;
            try
            {
                SqlCommand cmd = new SqlCommand("select * FROM StudentTbl where RollNo = \'" + rollno + "\'  ", connection);
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    if (read.Read())
                    {
                        email = (string)read["GuardianEmail"];
                        sndml.sendMail(finedetail, email);
                        gemail = (string)read["GuardianEmail"];
                        sndml.sendMail(finedetail, gemail);
                        return true;
                    }else
                    return false;
                }
            }
            catch (Exception)
            {

                connection.Close();
                MessageBox.Show("Error No Guardian Email Available!");
            }
            return false;
        }
        public string GetGContact(string rollno)
        {
            connection.Open();
            string contact = "0";
            FineRecord fr = null;
            try {
                //MessageBox.Show("rollno." + rollno);
                SqlCommand cmd = new SqlCommand("select * FROM StudentTbl where RollNo = \'" + rollno + "\' ", connection);
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    if (read.Read())
                    {
                        contact = (string)read["GuardianContact"];
                        return contact;
                    }
                    return contact;
                }
            }catch(Exception )
            {

                connection.Close();
                MessageBox.Show("Error No Guardian Contact Available!");
            }
            return contact;
        }
        public bool EnterFineRecord(FineRecord fr)
        {
            connection.Open();
            bool bol = false;
            int studentId = 0;
            int roomId = 0;
            int wardenId = 1;
            SqlCommand cmd = new SqlCommand("Select Id, RoomId from StudentTbl where RollNo = \'" + fr.RollNo + "\' ", connection);
            try
            {
                using (SqlDataReader read = cmd.ExecuteReader())
                {

                    if (read.Read())
                    {
                        studentId = (int)read["Id"];
                        roomId = (int)read["RoomId"];
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Student does not exist!");
                return bol;
            }
                SqlCommand cmd1;
            try
            { cmd1 = new SqlCommand("Select * from wardenTbl where LoginId = \'" + Login.Warden + "\'", connection);
                using (SqlDataReader read2 = cmd1.ExecuteReader())
                {
                    if (read2.Read())
                        wardenId = (int)read2["Id"];
                }
            }catch(Exception)
            {

                MessageBox.Show("Error occured with warden table!");
                return bol;
            }
                string query = "";
            try
            {  if (studentId != 0 && wardenId != 0 && roomId != 0)
                {
                    SqlCommand cmd2;
                    query = "INSERT INTO [dbo].[FineRecordTbl] ( [StudentId], [WardenId], [Amount], [FineDate], [DueDate], [FineDetail]) VALUES (\'"+studentId+ "\', \'" + wardenId + "\', \'" + fr.Amount + "\', \'" + fr.FineDate + "\', \'" + fr.DueDate + "\',\'" + fr.FineDetail + "\')";
                   // query = "INSERT INTO FineRecordTbl (StudentId, WardenId, Amount, FineDate, DueDate, FineDetail)  VALUES (\'" + studentId + "\',\'" + wardenId + "\',\'" + fr.Amount + "\',\'" + fr.FineDate + "\',\'" + fr.DueDate + "\',\'" + fr.FineDetail + "\'";
                    cmd2 = new SqlCommand(query, connection);
                    if (cmd2.ExecuteNonQuery() > 0)
                        bol = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Data Entry! : RoomId:" + roomId + ":Student Id: " + studentId + " Warden Id: " + wardenId);
            }
            connection.Close();
            return bol;
        }

    }
}
