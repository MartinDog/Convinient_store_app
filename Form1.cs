using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convinient_store_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pop_up_pay(Object sender, EventArgs e)
        {
            Form2 pay = new Form2();
            pay.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Remains remain = new Remains();
            remain.Show();
        }
    }
}
