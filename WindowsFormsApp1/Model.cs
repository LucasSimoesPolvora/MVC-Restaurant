using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Model
    {
        private Controler _controler;

        public Controler Controler { get => _controler; set => _controler = value; }

        public bool ProcessOrder(Order order) 
        {
            if (order.Name == "")
            {
                return false;
            }
            else if(order.Surname == "")
            {
                return false;
            }
            else if (order.Drink == -1)
            {
                return false;
            }
            else if(order.Drink == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
