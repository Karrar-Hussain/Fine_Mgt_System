using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace HFMS.Model
{
    class ModelStudent
    {
        public static int deleteStudent(string rollno)
        {
            int id = 0;
            int result = 0;
            SqlConnection db = new SqlConnection(ConfigurationSettings.AppSettings["ConStr"]);
            db.Open();
            SqlCommand select = new SqlCommand("select Id from StudentTbl where RollNo=@RollNo'" + rollno + "'", db);
            SqlDataReader r = select.ExecuteReader();
            if (r.Read())
            {
                id = Convert.ToInt32(r["Id"]);
            }
            r.Close();
            SqlCommand del = new SqlCommand("delete from StudentTbl where Id='"+id+"'",db);
           result = del.ExecuteNonQuery();

            SqlCommand del1 = new SqlCommand("delete from PersonTbl where Id='" + id + "'", db);
           result = del1.ExecuteNonQuery();
            return result;
        }
        public static int updateStudent(Student Obj)
        {
            int a = 0;
            int result = 0;
            SqlConnection db = new SqlConnection(ConfigurationSettings.AppSettings["ConStr"]);
            db.Open();
            SqlCommand cmd = new SqlCommand("update StudentTbl set RoomId='"+Obj.RoomNo+"',GuardianName='"+Obj.GuardianName+"',GuardianContact='"+Obj.GuardianContact+"',GuardianEmail='"+Obj.GuardianEmail+"',Relation='"+Obj.Relation+"' where RollNo='"+Obj.RollNo+"'" , db);
            result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            SqlCommand select = new SqlCommand("select Id from StudentTbl where RollNo='" + Obj.RollNo + "'", db);
            SqlDataReader r = select.ExecuteReader();
            if (r.Read())
            {
                a = Convert.ToInt32(r["Id"]);
            }
            r.Close();
            try
            {
                SqlCommand update = new SqlCommand("update PersonTbl set [First Name]='" + Obj.FirstName + "',[Last Name] ='" + Obj.LastName + "',CNIC = '" + Obj.CNIC + "',Contact = '" + Obj.contact + "',Email = '" + Obj.Email + "',Address = '" + Obj.Address + "',PType='" + Obj.Ptype + "' where Id='"+a+"'", db);
                result = update.ExecuteNonQuery();
                update.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
            db.Close();
            return result;
        }
        public static Student getStudent(string rollNo)
        {
            Student obj = new Student();
            SqlConnection db = new SqlConnection(ConfigurationSettings.AppSettings["ConStr"]);
            db.Open();
            try
            {
                SqlCommand select = new SqlCommand("select * from StudentTbl where RollNo='"+rollNo+"'",db);
                SqlDataReader r = select.ExecuteReader();
                if (r.Read())
                {
                    obj.Id = Convert.ToInt32(r["Id"]);
                    obj.RollNo = r["RollNo"].ToString();
                    obj.RoomNo = r["RoomId"].ToString();
                    obj.GuardianName = r["GuardianName"].ToString();
                    obj.GuardianEmail = r["GuardianEmail"].ToString();
                    obj.GuardianContact=r["GuardianContact"].ToString();
                    obj.Relation = r["Relation"].ToString();
                   
                }
                r.Close();
                SqlCommand cmd = new SqlCommand("select  *  from PersonTbl where Id='" + obj.Id + "'", db);
                SqlDataReader rr = cmd.ExecuteReader();
                if (rr.Read())
                {
                    obj.FirstName = rr["First Name"].ToString();
                    obj.LastName = rr["Last Name"].ToString();
                    obj.CNIC = rr["CNIC"].ToString();
                    obj.contact = rr["Contact"].ToString();
                    obj.Email = rr["Email"].ToString();
                    obj.Address = rr["Address"].ToString();
                    obj.Ptype = Convert.ToInt16(rr["PType"]);
                }
                rr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            db.Close();
            return obj;
        }
        public static int addStudent(Student Obj)
        {
            int a = 0;
            int result = 0;
            SqlConnection db = new SqlConnection(ConfigurationSettings.AppSettings["ConStr"]);
            db.Open();
            try {
                SqlCommand insert = new SqlCommand("insert into PersonTbl values ('" + Obj.FirstName + "','" + Obj.LastName + "','" + Obj.CNIC + "','" + Obj.contact + "','" + Obj.Email + "','" + Obj.Address + "','" + Obj.Ptype + "')", db);
                result=insert.ExecuteNonQuery();
                insert.Dispose();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            SqlCommand select = new SqlCommand("select Id from PersonTbl where CNIC='" + Obj.CNIC + "'", db);
            SqlDataReader r = select.ExecuteReader();
            if (r.Read())
            {
               a =  Convert.ToInt32(r["Id"]);
            }
            r.Close();
            SqlCommand cmd = new SqlCommand("insert into StudentTbl values ('" + a + "','" + Obj.RollNo + "','" + Obj.RoomNo + "','" + Obj.GuardianName + "','" + Obj.GuardianContact + "','" + Obj.GuardianEmail + "','" + Obj.Relation + "')", db);
            result = cmd.ExecuteNonQuery();
            db.Close();
            return result;
        }
    }
}
