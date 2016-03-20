using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace HFMS.model
{
    class Roomdb
    {
        SqlConnection conn = new SqlConnection(ConfigurationSettings.AppSettings["ConStr"]);
        public bool insert(Room room)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("INSERT INTO RoomTbl ([Beds], [Vacancy], [FloorNumber])VALUES (\'" + room.Beds + "\',\'" + room.Vacancy + "\',\'" + room.FloorNo + "\');", conn);
                cmd.ExecuteNonQuery();
                //cmd = new SqlCommand("INSERT INTO StudentTbl ([First Name], [Last Name], [CNIC], [Contact],[Email],[Address],[PType])VALUES (\'" + person.FirstName + "\',\'" + person.LastName + "\',\'" + person.CNIC + "\',\'" + person.contact + "\',\'" + person.Email + "\',\'" + person.Address + "\',\'" + person.Ptype + "\');", conn);
                //cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);

            }
            conn.Close();
            return false;
        }

        public bool search( ref Room room)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("select * from RoomTbl where Id=\'" + room.Id + "\'", conn);
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    if (read.Read())
                    {
                        room.Id = (int)read["Id"];
                        room.Beds = (int)read["Beds"];
                        room.Vacancy = (int)read["Vacancy"];
                        room.FloorNo = (int)read["FloorNumber"];
 
                    }
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            conn.Close();
            return false;
        }
        public bool Update(Room room)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("update RoomTbl set Beds=\'" + room.Beds + "\',Vacancy=\'" + room.Vacancy + "\',FloorNumber=\'" + room.FloorNo + "\' where Id=\'" + room.Id + "\';", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            conn.Close();
            return false;
        }
        public bool Delete(Room room)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("Delete from RoomTbl where id =\'" + room.Id + "\';", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            conn.Close();
            return false;
        }
        

    }
}
