using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace HFMS.Model
{
    class ModelLogin
    {
        public static string[] CheckPassword(String name, String Password)
        {
            string[] result = new string[2];
            SqlConnection db = new SqlConnection(ConfigurationSettings.AppSettings["ConStr"].ToString());

            db.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from WardenTbl where LoginId='"+name+"'",db);
                cmd.ExecuteNonQuery();
                SqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    result[0] = r["Password"].ToString();
                    result[1] =(string) r["Designation"];
                }
            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace);
            }
        
            db.Close();
            return result;
        }
        public static void updateStatus(string name)
        {
            SqlConnection db = new SqlConnection(ConfigurationSettings.AppSettings["ConStr"].ToString());
            db.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update WardenTbl set loggedIn='true' where LoginId='"+name+"'", db);
                cmd.ExecuteNonQuery();
            }
            catch(Exception e )
            {
                Console.Write(e.StackTrace);
            }
            db.Close();
        }


        public static string currentLoginID()
        {
            string name=Login.Warden;
            string result = "NULL";
            SqlConnection db = new SqlConnection(ConfigurationSettings.AppSettings["ConStr"]);
            db.Open();
            try
            {
                
                SqlCommand cmd = new SqlCommand("select LoginID from WardenTbl where loggedIn='true'", db);
                cmd.ExecuteNonQuery();
                SqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                    result = r["LoginID"].ToString();

            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace);
            }

            db.Close();
            return name;
        }

        public static bool updateLoginID(string oldname , string newname)
        {
            bool result = false;
            SqlConnection db = new SqlConnection(ConfigurationSettings.AppSettings["ConStr"].ToString());
            db.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update WardenTbl set LoginID='"+newname+"' where LoginId='" + oldname + "'", db);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace);
            }
            db.Close();
            return result;
        }

        public static bool updatePassword(string password, string name)
        {
            bool result = false;
            SqlConnection db = new SqlConnection(ConfigurationSettings.AppSettings["ConStr"].ToString());
            db.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update WardenTbl set Password='" + password + "' where LoginId='" + name + "'", db);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace);
            }
            db.Close();
            return result;
        }

        public static bool updateOffice(string Office, string name)
        {
            bool result = false;
            SqlConnection db = new SqlConnection(ConfigurationSettings.AppSettings["ConStr"].ToString());
            db.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update WardenTbl set OfficeLocation='" + Office + "' where LoginId='" + name + "'", db);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace);
            }
            db.Close();
            return result;
        }
    }
}
