using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_Ckawakam_300821245_A7
{
    static class Program
    {
        public static SplashScreenForm SplashScreen;
        public static SelectionForm FirstForm;
        public static OrderForm SecondForm;
        public static StreamForm ThirdForm;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SecondForm = new OrderForm();
            FirstForm = new SelectionForm();
            ThirdForm = new StreamForm();
            SplashScreen = new SplashScreenForm();
            Application.Run(SplashScreen);
        }
    }
}
