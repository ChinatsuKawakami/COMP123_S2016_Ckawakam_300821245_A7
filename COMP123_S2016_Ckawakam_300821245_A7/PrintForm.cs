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
    
    public partial class PrintForm : Form
    {
        public OrderForm SecondForm = Program.SecondForm;
        public PrintForm()
        {
            InitializeComponent();
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            //Make a reference to this From from OrderForm
            this.SecondForm.MenuPrintForm = this;
            this.TitleResultLabel.Text = SecondForm.TitleTextBox.Text;
            this.CategoryResultLabel.Text = SecondForm.CategoryTextBox.Text;
            this.CostResultLabel.Text = SecondForm.CostTextBox.Text;
            this.SubtotalResultLabel.Text = SecondForm.SubTotalTextBox.Text;

        }

        
       
    }
}
