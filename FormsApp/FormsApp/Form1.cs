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
        double xAddition = 0;

        public Form1()
        {
            //pri vzniku okna
            InitializeComponent();
        }

        public int getVyska()
        {
            return pictrOutput.Height;
        }

        public int getSirka()
        {
            return pictrOutput.Width;
        }

        public double getXAngle(int vlnovaDlzka)
        {            
            xAddition = xAddition + Math.PI * 2 / vlnovaDlzka;
            return xAddition;
        }
        public int getYValue(bool sin, double yBefore)
        {
            int vlnovaDlzka = Convert.ToInt32(txtbxLambda.Text);
            int amplituda = Convert.ToInt32(txtbxYm.Text);

            yBefore = Math.Sin(getXAngle(vlnovaDlzka));





            if (sin)
                return (int)((getVyska() / 2) - (yBefore * amplituda));
            else
                return (int)((getVyska() / 2) + (yBefore * amplituda));
        }
        public void paintSin(bool sin)
        {
            Graphics mg = pictrOutput.CreateGraphics();

            
            
            double xAddition = 0;
            double yBefore = 0;

            int y = 0;
            int xGold = 0;
            int yGold = (int)getVyska() / 2;

            for (int x = 0; x <= getSirka(); x++)
            {

                                           
                mg.DrawLine(coloredPen, xGold, yGold, x, getYValue(sin,yBefore));

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
            paintSin(true);                                                                 
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            paintSin(false);
        }

        
    }
}
