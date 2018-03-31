using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PTAS
{
    public class Splasher
    {
        static SplashForm MySplashForm = null;
        static Thread MySplashThread = null;

        static void ShowThread()
        {
            MySplashForm = new SplashForm();
            Application.Run(MySplashForm);
        }

        public static void Show()
        {
            if (MySplashThread != null) return;

            MySplashThread = new Thread(new ThreadStart(ShowThread))
            {
                IsBackground = true
            };
            MySplashThread.SetApartmentState(ApartmentState.STA);
            MySplashThread.Start();
        }

        public static void Close()
        {
            if (MySplashThread == null) return;
            if (MySplashForm == null) return;

            try
            {
                MySplashForm.Invoke(new MethodInvoker(MySplashForm.Close));
            }
            catch (Exception e)
            {
                string hash = e.GetHashCode().ToString();
                MessageBox.Show("Exception occurred: " + hash);
            }

            MySplashForm = null;
            MySplashThread = null;
        }

        public static string Status
        {
            set
            {
                if (MySplashForm == null) return;
                MySplashForm.StatusInfo = value;
            }
            get
            {
                if (MySplashForm == null)
                    throw new InvalidOperationException("Splash Form not on screen");
                return MySplashForm.StatusInfo;
            }
        }
    }
}
