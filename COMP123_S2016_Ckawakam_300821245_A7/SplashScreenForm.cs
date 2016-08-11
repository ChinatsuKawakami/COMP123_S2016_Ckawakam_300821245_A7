using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP123_S2016_Ckawakam_300821245_A7.Properties;

namespace COMP123_S2016_Ckawakam_300821245_A7
{
    public partial class SplashScreenForm : Form
    {
        //Alias
        public SelectionForm FirstForm = Program.FirstForm;

        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void SplashScreenFromTimer_Tick(object sender, EventArgs e)
        {
            SplashScreenFromTimer.Enabled = false;
            FirstForm.Show();
            this.Hide();
            FirstForm.FormClosed += FirstForm_FormClosed;

        }
        private void FirstForm_FormClosed(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
