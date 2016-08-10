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
{/*
  * Description:This is the Form to calculate to cost of the movies which come from dataserver
  * Author: Chinatsu Kawakami
  * Create Date: 8th August 2016
  * Modified Date: 10th August 2016
  * Version: 0.0.5 - set Button and anylabels in StreamForm
  */
    public partial class SelectionForm : Form
    {
        public OrderForm SecondForm = Program.SecondForm;
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //Gray-out this From if user pushes Next Button
            this.Enabled = false;

            this.SecondForm.TitleTextBox.Text = this.TitleTextBox.Text;
            this.SecondForm.CategoryTextBox.Text = this.CategoryTextBox.Text;
            this.SecondForm.CostTextBox.Text = this.CostTextBox.Text;
            this.SecondForm.SubTotalTextBox.Text = this.CostTextBox.Text;
           // this.SecondForm.SalesTotalTextBox.Text = Convert.ToDouble(this.SecondForm.SubTotalTextBox.Text) * 1.13;
          //
            this.SecondForm.OrderPictureBox.Image = this.SelectionPictureBox.Image;
            
            this.Close();
            this.SecondForm.Show();

        }

      
    }
}
