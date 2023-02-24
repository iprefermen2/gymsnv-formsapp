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

        public void nullThings(int start)
        {
            xAddition = 0;
            yBefore = 0;
            xGold = start;
            yGold = (int)getVyska() / 2;
        }

        public double getFyzRatio(double one, double two)
        {
            return two + Math.Abs(one);
        }

        //daco tu ma byt ze to mame dat akoze do nejake fyzikalne dacoho ze napr ked mam nieco od 20 do 380 tak to znamena ze na fyz to bude
        //-2 az 2 alebo nejake ine cisla neviem presne akoze co ale daco taketo podobne asi 


        //urobit nejake dve funckie, nie pre realne cisla abysme mohli davat a zacat 2pi tripi cidaco take
        public double getXAngle()
        {
            xAddition = xAddition + getFyzRatio(0,Math.PI*2) / getVlnovaDlzka();
            return xAddition; 
        }

        public int getYSinValue(bool sin)
        {
            yBefore = Math.Sin(getXAngle());



            if (sin)
               return (int)((getVyska() / 2) - (yBefore * getAmplituda()));
            else
                return (int)((getVyska() / 2) + (yBefore * getAmplituda()));
        }

        public void paintSin(bool sin, int startPoint, int endPoint)
        {
            nullThings(startPoint);

            Graphics mg = pictrOutput.CreateGraphics();          
                             

            for (int x = startPoint; x <= endPoint; x++)
            {
                int y = getYSinValue(sin);             
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
            paintSin(true,20,380);                                                                 
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            paintSin(false,20,380);
        }

        
    }
}
