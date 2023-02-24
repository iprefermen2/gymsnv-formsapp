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

        public double getVlnovaDlzka()
        {
            return Convert.ToInt32(txtbxLambda.Text);
        }

        public double getAmplituda()
        {
            return Convert.ToInt32(txtbxYm.Text);
        }

        public int getVyska()
        {
            return Convert.ToInt32(pictrOutput.Height);
        }
        public int getSirka()
        {
            return Convert.ToInt32(pictrOutput.Width);
        }

        double xAddition = 0;
        double yBefore = 0;
        int xGold = 0;
        int yGold;

        public Form1()
        {
            //pri vzniku okna
            InitializeComponent();
        }

        public void nullThings()
        {
            xAddition = 0;
            yBefore = 0;
            xGold = 0;
            yGold = (int)getVyska() / 2;
        }

        

        public double getXAngle()
        {
            xAddition = xAddition + Math.PI * 2 / getVlnovaDlzka();
            return xAddition; 
        }

        public int getYValue(bool sin)
        {
            yBefore = Math.Sin(getXAngle());



            if (sin)
               return (int)((getVyska() / 2) - (yBefore * getAmplituda()));
            else
                return (int)((getVyska() / 2) + (yBefore * getAmplituda()));
        }

        public void paintSin(bool sin)
        {
            nullThings();

            Graphics mg = pictrOutput.CreateGraphics();          
          
          
            int xGold = 0;
            int yGold = (int)getVyska() / 2;

            for (int x = 0; x <= getSirka(); x++)
            {
                int y = getYValue(sin);             
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
            paintSin(true);                                                                 
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            paintSin(false);
        }

        
    }
}
