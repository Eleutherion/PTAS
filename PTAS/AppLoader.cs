using System;
using System.Windows.Forms;

namespace PTAS
{
    class AppLoader
    {
        private static ApplicationContext context;
        private static SplashForm sForm = new SplashForm();
        private static frmLogin mForm = new frmLogin();

        [STAThread]
        static void Main(string[] args)
        {
            Splasher.Show();
            DoStartup(args);
            Splasher.Close();
        }

        //private static void OnAppIdle(object sender, EventArgs e)
        //{
        //    Application.Idle -= new EventHandler(OnAppIdle);
        //    mForm.PreLoad();
        //    context.MainForm = mForm;
        //    context.MainForm.Show();

        //    sForm.Close();
        //    sForm = null;
        //}

        static void DoStartup(string[] args)
        {
            frmLogin f = new frmLogin();
            Application.Run(f);
        }
    }
}
