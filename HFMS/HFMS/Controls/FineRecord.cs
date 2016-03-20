using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFMS
{
    class FineRecord
    {
        public int Id { set; get; }
        public String RollNo
        {
            set;
            get;
        }
        public int Amount
        {
            set;
            get;
        }
        public DateTime DueDate
        {
            set;
            get;
        }
        public DateTime FineDate
        {
            set;
            get;
        }
        public string FineDetail
        {
            set;
            get;
        }
        public int Charges
        {
            set;
            get;
        }
    }
}
