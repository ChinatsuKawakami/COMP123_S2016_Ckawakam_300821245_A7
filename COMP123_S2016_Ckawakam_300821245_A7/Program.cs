using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_Ckawakam_300821245_A7
{
    static class Program
    {
      //  public static SplashScreenForm SplashScreen;
      //  public static SelectionForm FirstForm;
      // public static OrderForm SecondForm;
      // public static StreamForm ThirdForm;
       // public static PrintForm MenuPrintForm;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


          //  ThirdForm = new StreamForm();

          //  SecondForm = new OrderForm();
          //  MenuPrintForm = new PrintForm();
          // FirstForm = new SelectionForm();

          
          //  SplashScreen = new SplashScreenForm();


            Application.Run(new SplashScreenForm());
        }
    }
}
