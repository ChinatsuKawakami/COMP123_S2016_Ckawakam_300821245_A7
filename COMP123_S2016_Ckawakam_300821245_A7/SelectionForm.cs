using COMP123_S2016_Ckawakam_300821245_A7.Models;
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
  * Modified Date: 19th August 2016
  * Description: This Form displays which movie user choose and how much cost to get it (they come from DataBase Server)
  * Version: 0.0.17 - Resize all Form and change the size of literatures
  */
    public partial class SelectionForm : Form
    {

        public OrderForm SecondForm;// = Program.SecondForm;
      

       // public List<Models.MovieDataContext> Movies = new List<Models.MovieDataContext>();
    

        //Make Two of Lists to store data which are category and DownloadCost
     public List<string> CategoryList = new List<string>();
         
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
            
               //Gray-out this From until user chooses movie
               NextButton.Enabled = false;
              
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //instanciate the OrderForm(secondForm) 
            SecondForm = new OrderForm();

            //Transfer SelectionForm's Title to OrderForm's Title
            this.SecondForm.TitleTextBox.Text = this.TitleTextBox.Text;
            //Transfer SelectionForm's Category to OrderForm's Category
            this.SecondForm.CategoryTextBox.Text = this.CategoryTextBox.Text;
            //Transfer SelectionForm's Cost to OrderForm's Cost
            this.SecondForm.CostTextBox.Text = this.CostTextBox.Text;
        


            this.SecondForm.OrderPictureBox.Image = this.SelectionPictureBox.Image;
         
        
            // make a reference to This class in OrderForm(SecondForm)
        
            SecondForm.FirstForm = this;
         
            
            this.SecondForm.Show();
            
            // event handler for showing this form when SecondForm close
            this.SecondForm.FormClosed += SecondForm_close;
            this.Hide();

           
          
            
        }

        private void SecondForm_close(object sender, EventArgs e)
        {
            this.Show();
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'cOMP123DataSet.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.cOMP123DataSet.Movies);


           //  TODO: This line of code loads data into the 'cOMP123DataSet.Categories' table. You can move, or remove it, as needed.
      //   this.categoriesTableAdapter.Fill(this.cOMP123DataSet.Categories);

            //Set Default Value for MovieListBox 
            MovieListBox.SelectedIndex = 0;

        }

     
        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Next Button can be pushed if user selects one of the movies
            NextButton.Enabled = true;
            //Transfer MovieListBox's Title to TitleTextBox
            this.TitleTextBox.Text = MovieListBox.Text;

            //Set MoviesImage in PictureBox refer to MovieListBox's SelectedIndex
            this.SelectionPictureBox.Image = this.MovieImageList.Images[(int)MovieListBox.SelectedIndex];
        
            /* Category category = new Category();
            Category price = new Category();
           Movie movies = new Movie();
           MovieDataContext db = new MovieDataContext();

           string connectString = System.Configuration..ConnectionStrings["LinqToSQLDBConnectionString"].ToString();

            LinqToSQLDataContext db = new LinqToSQLDataContext(connectString);

           category = db.Categories.FirstOrDefault(cate => cate.CategoryID.Equals(movies.CategoryID_FK));
            
           this.CategoryTextBox.Text = category.Category1.ToString();
            this.CostTextBox.Text = category.DownloadCost.ToString();
            */

            //Category and DownLoadCost will be chose depends on SeletedIndex of MovieListBox
                 switch ((int)MovieListBox.SelectedIndex)
                {
                    case 2:
                    case 5:
                    case 13:
                    case 15:
                        this.CategoryTextBox.Text = CategoryList[0].ToString();
                        this.CostTextBox.Text = Cost[0].ToString();
                        break;
                    case 4:
                    case 6:
                    case 12:
                        this.CategoryTextBox.Text = CategoryList[1].ToString();
                        this.CostTextBox.Text = Cost[0].ToString();
                        break;
                    case 1:
                    case 3:
                    case 7:
                    case 9:
                    case 10:
                    case 16:
                        this.CategoryTextBox.Text = CategoryList[2].ToString();
                        this.CostTextBox.Text = Cost[1].ToString();
                        break;
                    case 0:
                    case 17:
                        this.CategoryTextBox.Text = CategoryList[3].ToString();
                        this.CostTextBox.Text = Cost[1].ToString();
                        break;
                    case 8:
                        this.CategoryTextBox.Text = CategoryList[4].ToString();
                        this.CostTextBox.Text = Cost[1].ToString();
                        break;
                    case 11:
                        this.CategoryTextBox.Text = CategoryList[5].ToString();
                        this.CostTextBox.Text = Cost[1].ToString();
                        break;
                    case 14:
                        this.CategoryTextBox.Text = CategoryList[6].ToString();
                        this.CostTextBox.Text = Cost[2].ToString();
                        break;
                    case 18:
                    case 19:
                        this.CategoryTextBox.Text = CategoryList[7].ToString();
                        this.CostTextBox.Text = Cost[3].ToString();
                        break;

                }
            
         
          //this.SelectionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;

            
           
            }

        private void SelectionForm_Activated(object sender, EventArgs e)
        {
           // TODO: This line of code loads data into the 'cOMP123DataSet.Movies' table. You can move, or remove it, as needed.
         //  this.moviesTableAdapter.Fill(this.cOMP123DataSet.Movies);
          

            //  TODO: This line of code loads data into the 'cOMP123DataSet.Categories' table. You can move, or remove it, as needed.
         //  this.categoriesTableAdapter.Fill(this.cOMP123DataSet.Categories);

        }

        

     
    

      

     
        }


}
      
 
