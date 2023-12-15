using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Model
    {
        Controler _controler = new Controler();

        public Controler Controler { get => _controler; set => _controler = value; }
    }
}
