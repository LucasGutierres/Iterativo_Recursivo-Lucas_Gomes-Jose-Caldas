using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double CalIte(double num)
        {
          
            double x = num;
            
            for (double i = num-1; i > 0; i--) {

                x *= i;

            }

            return x;

        }

        public double CalRec(double num)
        {
            if (num == 0)
            {

                return 1;

            }

            return num*CalRec(num - 1);

        }

        private void Iterativo(object sender, EventArgs e)
        {
            Button butt = sender as Button;
            double NumNum = Double.Parse(txt.Text);
            lbl.Text = Convert.ToString(CalIte(NumNum));
        }

        private void Recursivo(object sender, EventArgs e)
        {
            Button butt = sender as Button;
            double NomNom = Double.Parse(txt.Text);
            lbl.Text = Convert.ToString(CalRec(NomNom));
        }
    }
}
