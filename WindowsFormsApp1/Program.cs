using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Model model = new Model();
            Controler controler = new Controler();
            Form1 view = new Form1();

            model.Controler = controler;
            view.Controler = controler;
            controler.View = view;
            controler.Model = model;

            Application.Run(view);
        }
    }
}
