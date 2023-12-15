using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Controler
    {
        private Model _model;
        private Form1 _view;
        string msg;

        public Model Model { get => _model; set => _model = value; }
        public Form1 View { get => _view; set => _view = value; }

        public void processOrder(Order order)
        {
            if (Model.ProcessOrder(order))
            {
                View.displaySuccess("Commande effectuée");
            }
            else
            {
                View.displayError(Model.getError());
            }
        }
    }
}
