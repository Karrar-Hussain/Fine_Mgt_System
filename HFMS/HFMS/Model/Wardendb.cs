using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFMS.model
{
    class Wardendb
    {
        public static int addWarden(Warden warden )
        {
            int a = 0;
            int result = 0;
            SqlConnection db = new SqlConnection(ConfigurationSettings.AppSettings["ConStr"]);
            db.Open();
            try
            {
                warden.Ptype = 1;
                SqlCommand insert = new SqlCommand("insert into PersonTbl values ('" + warden.FirstName + "','" + warden.LastName + "','" + warden.CNIC + "','" + warden.contact + "','" + warden.Email + "','" + warden.Address + "','" + warden.Ptype + "')", db);
                result = insert.ExecuteNonQuery();
                insert.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            SqlCommand select = new SqlCommand("select Id from PersonTbl where CNIC='" + warden.CNIC + "'", db);
            try
            {
                SqlDataReader r = select.ExecuteReader();
                if (r.Read())
                {
                    a = Convert.ToInt32(r["Id"]);
                }
                r.Close();
                SqlCommand cmd = new SqlCommand("insert into WardenTbl (Id, RoomId, LoginId, Designation,OfficeLocation,Password) values ('" + a + "','" + warden.RoomNo + "','" + warden.LoginId + "','" + warden.Designation + "','" + warden.OfficeLocation + "','" + warden.Password + "')", db);
                result = cmd.ExecuteNonQuery();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            db.Close();
            return result;
        }
    }
}
