using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locations
{
    public partial class frmShowDialog : Form
    {
        public frmShowDialog()
        {
            InitializeComponent();
        }

        private void frmShowDialog_Load(object sender, EventArgs e)
        {
            lblAddressValue.Text = Form1.adres;
            lblGsmValue.Text = Form1.gsm;
            lblNameValue.Text = Form1.name; 
        }
    }
}
