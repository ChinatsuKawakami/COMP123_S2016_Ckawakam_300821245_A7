using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_Ckawakam_300821245_A7
{
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
         
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //terminate
            Application.Exit();
        }
    }
}
