using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFMS
{
    public class Person
    {
        public int Id { set; get; }  
        public string FirstName
        {
            set;
            get;
        }
        public string Address
        {
            set;
            get;
        }
        public string LastName
        {
            set;
            get;
        }
        public int Ptype
        {
            set;
            get;
        }
        public string contact
        {
            set;
            get;
        }
        public string Email
        {
            set;
            get;
        }
        public string CNIC { get; internal set; }
    }

}
