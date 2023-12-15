using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Order
    {
        private string name;
        private string surname;
        private int dish;
        private int drink;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Dish { get => dish; set => dish = value; }
        public int Drink { get => drink; set => drink = value; }
    }
}
