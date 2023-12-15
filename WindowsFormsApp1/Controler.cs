using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Controler
    {
        private Model _model = new Model();
        private Form1 _view = new Form1();

        public Model Model { get => _model; set => _model = value; }
        public Form1 View { get => _view; set => _view = value; }
    }
}
