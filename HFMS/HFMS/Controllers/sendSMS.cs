using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GsmComm.GsmCommunication;
using GsmComm.Server;
using GsmComm.PduConverter;
using System.Windows.Forms;

namespace HFMS.Controllers
{
    class sendSMS
    {
        GsmCommMain gsmcom;
        public bool Sendsms(String msg,String contact )
        {
            bool bol = false;
            try
            {
                //var phoneNumber = contact;
                var phoneNumber = "+923138251224";
                var pdu = new SmsSubmitPdu(msg, contact, string.Empty);
                //SmsSubmitPdu pdu;
                //byte msg = (byte)DataCodingScheme.DataCoding.Alpha7BitDefault;
                //pdu = new SmsSubmitPdu(txtAddress.Text, txtContact.Text, msg);
                int time = 3;
                for (int i = 0; i < time;i++)
                {
                    gsmcom.SendMessage(pdu);
                }

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("modem is not available");
                return false;
            }
            return true;
        }

        public bool SetCOMNum(String com)
        {

            gsmcom = new GsmCommMain(com, 9600, 150);
            Cursor.Current = Cursors.Default;
            bool retry;
            do
            {
                retry = false;
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    gsmcom.Open();
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Connected Successfully!");
                    return true;

                }
                catch (Exception)
                {
                    return false;
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Error in Connection With Provided COM Try an-Other COM!");
                }
            } while (retry);

        }
    }
}
