using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Model
    {
        private Controler _controler;

        public Controler Controler { get => _controler; set => _controler = value; }

        private int errorNumber;
        private string msg;

        public bool ProcessOrder(Order order) 
        {
            if (order.Name == "" || order.Surname == "")
            {
                errorNumber = 1;
                msg = "Le nom ou/et le prénom sont vides";
                return false;
            }
            else if (order.Drink == -1 && order.Drink == -1)
            {
                errorNumber = 2;
                msg = "Vous ne commandez rien";
                return false;
            }
            else
            {
                return true;
            }
        }

        public string getError()
        {
            return "Erreur " + errorNumber + " : " +  msg;
        }
    }
}
