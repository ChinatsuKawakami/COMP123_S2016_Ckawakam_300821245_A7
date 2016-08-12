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
 /**
  * Author: Chinatsu Kawakami
  * StudentID : 300821245
  * Create Date: 8th August 2016
  * Modified Date: 12th August 2016
  * Description: This Form displays which movie user choose and how much cost to get it (they come from DataBase Server)
  * Version: 0.0.8 - Addedd PrintForm and Fix calculation for Grand Total in OrderForm
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
         
         
            this.SecondForm.OrderPictureBox.Image = this.SelectionPictureBox.Image;
         
        
            // make a reference to This class in OrderForm(SecondForm)
        
            SecondForm.FirstForm = this;
            this.SecondForm.Show();
            this.Close();
           

        }

        private void SelectionForm_Load(object sender, EventArgs e)
        { 
            //int index = this.MovieListBox.SelectedIndex;
            for (int index = 0; index < 20; index++)
            {
                this.SelectionPictureBox.Image = this.MovieImageList.Images[index];
            }
        }

      
    }
}
