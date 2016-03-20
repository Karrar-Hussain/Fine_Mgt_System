using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFMS
{
    public partial class HFMS_WINDOW : Form
    {
        public HFMS_WINDOW()
        {
            InitializeComponent();
        }
        public Panel getPanel()
        {
            return MainPanel;
        } 
        private void HFMS_WINDOW_Load(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(StudentEntry.instance))
            {
                MainPanel.Controls.Add(StudentEntry.instance);
                StudentEntry.instance.BringToFront();
             }
            else
                StudentEntry.instance.BringToFront();
        }
        private void setPanel()
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
