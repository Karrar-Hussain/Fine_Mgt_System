using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFMS.Controls
{
    class Login
    {
        public static bool updateLoginID(string oldname , string newname)
        {
           return  Model.ModelLogin.updateLoginID(oldname, newname);
        }
        public static bool updatePassword(string password, string name)
        {
            return Model.ModelLogin.updatePassword(password, name);
        }
        public static bool updateOffice(string Office, string name)
        {
            return Model.ModelLogin.updateOffice(Office, name);
        }
        public static void updateStatus(string name)
        {
            Model.ModelLogin.updateStatus(name);
        }
        public static string currentLoginID()
        {
            return Model.ModelLogin.currentLoginID();
        }
        public static string[] checkPassword(string name, string password)
        {
            string[] result = Model.ModelLogin.CheckPassword(name,password);
            return result;
        }
    }
}
