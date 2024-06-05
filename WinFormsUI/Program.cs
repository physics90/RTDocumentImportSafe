using System;
using System.Windows.Forms;
using V = VMS.TPS.Common.Model.API;

namespace WinFormsUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            //Create Aria Environment for Standalone
            try
            {
                using (V.Application app = V.Application.CreateApplication())
                {
                    Execute(app);
                }
            }
            catch (Exception)
            {
                using (V.Application app = null)
                {
                    Execute(app);
                }
                
            }
            
        }

        private static void Execute(V.Application app)
        {
            Main main = new Main();

            if (app != null)
            {
                V.User user = app.CurrentUser;

                main.App = app;
                main.User = user;
            }

            Application.Run(main);

           
        }
    }
}
