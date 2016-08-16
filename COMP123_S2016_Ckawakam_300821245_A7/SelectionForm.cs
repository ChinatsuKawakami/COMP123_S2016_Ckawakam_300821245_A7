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
  * Modified Date: 15th August 2016
  * Description: This Form displays which movie user choose and how much cost to get it (they come from DataBase Server)
  * Version: 0.0.10 - Added List of Costs
  */
    public partial class SelectionForm : Form
    {
        
        public OrderForm SecondForm = Program.SecondForm;

        public List<string>CategoryList = new List<string>();
         
        public List<double> Cost = new List<double>();
          

        public SelectionForm()
        {
            InitializeComponent();
               CategoryList.AddRange(new List<string>
                {
                  "Comedy","Drama","Action","Sci-Fi","Horror","Thriller","Family","New Releases"
                });
               Cost.AddRange(new List<double>
                {
                    1.99,2.99,0.99,4.99
                });
              
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
           // Default Value

            this.MovieListBox.SelectedIndex = 0;

        }

      
        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            TitleTextBox.Text = MovieListBox.SelectedItem.ToString();
          
            switch((int)MovieListBox.SelectedIndex)
            {
                case 2:
                case 5:
                case 13:
                case 15:
                    this.CategoryTextBox.Text = CategoryList[0]; 
                    this.CostTextBox.Text = Cost[0].ToString();
                    break;
                case 4:
                case 6:
                case 12:
                    this.CategoryTextBox.Text = CategoryList[1];
                    this.CostTextBox.Text = Cost[0].ToString();
                    break;
                case 1:
                case 3:
                case 7:
                case 9:
                case 10:
                case 16:
                    this.CategoryTextBox.Text = CategoryList[2];
                    this.CostTextBox.Text = Cost[1].ToString();
                    break;
                case 0:
                case 17:
                    this.CategoryTextBox.Text = CategoryList[3];
                    this.CostTextBox.Text = Cost[1].ToString();
                    break;
                case 8:
                    this.CategoryTextBox.Text = CategoryList[4];
                    this.CostTextBox.Text = Cost[1].ToString();
                    break;
                case 11:
                    this.CategoryTextBox.Text = CategoryList[5];
                    this.CostTextBox.Text = Cost[1].ToString();
                    break;
                case 14:
                    this.CategoryTextBox.Text = CategoryList[6];
                    this.CostTextBox.Text = Cost[2].ToString();
                    break;
                case 18:
                 case 19:
                    this.CategoryTextBox.Text = CategoryList[7];
                    this.CostTextBox.Text = Cost[3].ToString();
                    break;

            }

        
                 this.SelectionPictureBox.Image = this.MovieImageList.Images[(int)MovieListBox.SelectedIndex];
              
            }
            
        }

     
}
      
 
