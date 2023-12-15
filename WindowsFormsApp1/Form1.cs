using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Controler _controler;

        public Controler Controler { get => _controler; set => _controler = value; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Name = this.Name.Text;
            order.Surname = this.Surname.Text;
            order.Dish = this.dish.SelectedIndex;
            order.Drink = this.drink.SelectedIndex;

            MessageBox.Show("jalsdkla");
        }
    }
}
