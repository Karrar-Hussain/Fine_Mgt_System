using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HFMS.model
{
    class Persondb
    {
        SqlConnection conn =new SqlConnection("Data Source=(localdb)\\Projects;Initial Catalog=HFMS_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
        public bool insert(Person person)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();                
                cmd = new SqlCommand("INSERT INTO PersonTbl ([First Name], [Last Name], [CNIC], [Contact],[Email],[Address],[PType])VALUES (\'" + person.FirstName + "\',\'" + person.LastName + "\',\'" + person.CNIC + "\',\'" + person.contact + "\',\'" + person.Email + "\',\'" + person.Address + "\',\'" + person.Ptype + "\');", conn);
                cmd.ExecuteNonQuery();
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
