using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace RosaParksServices2
{
    public partial class RosaParksServices : Form
    {
        public RosaParksServices()
        {
            InitializeComponent();
        }

        private void RosaParksServices_Load(object sender, EventArgs e)
        {
            using (StreamWriter outputFile = new StreamWriter("C:\\LOCAL DOCUMENTS\\RosaParksServices\\Update.htm"))
            {
                    outputFile.WriteLine("<html><head><meta http-equiv=\"refresh\" content=\"0; url = \'\\\\10.68.130.243\\PCClient\\jeremiah3.htm\'\" /></head><body></body></html>\r\n");
            }
        }
    }
}
