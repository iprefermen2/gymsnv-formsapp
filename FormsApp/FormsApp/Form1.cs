using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        

        Pen coloredPen = new Pen(Color.Lime, 2);
        
        public Form1()
        {
            //pri vzniku okna
            InitializeComponent();
        }

        public void paintSin(string lambda, string ym, bool sin)
        {
            Graphics mg = pictrOutput.CreateGraphics();

            double vlnovaDlzka = Convert.ToInt32(lambda);
            double amplituda = Convert.ToInt32(ym);
            double sirka = pictrOutput.Width;
            double vyska = pictrOutput.Height;

            double xAddition = 0;
            double yBefore = 0;

            int y = 0;
            int xGold = 0;
            int yGold = (int)vyska / 2;

            for (int x = 0; x <= sirka; x++)
            {


                xAddition = xAddition + Math.PI * 2 / vlnovaDlzka;




                yBefore = Math.Sin(xAddition);



                if(sin)
                y = (int)((vyska / 2) - (yBefore * amplituda));
                else
                    y = (int)((vyska / 2) + (yBefore * amplituda));



                mg.DrawLine(coloredPen, xGold, yGold, x, y);

                xGold = x;
                yGold = y;


            }
        }

        


        private void btnDelete_Click(object sender, EventArgs e)
        {
            pictrOutput.Image = null;     
        }



        private void btnSin_Click(object sender, EventArgs e)
        {
            paintSin(txtbxLambda.Text,txtbxYm.Text,true);                                                                 
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            paintSin(txtbxLambda.Text, txtbxYm.Text, false);
        }

        
    }
}
