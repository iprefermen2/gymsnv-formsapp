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
        Graphics mojaG;
        int xGraf = 50;// v px
        int yGraf = 50;

        double xFyz = 100.0;// v metroch
        double yFyz = 100.0;// v metroch

        double vx = 100.0;  // v m/s
        double vy = 200.0;  // v m/s

        double ax = 0.0;  // v m/s/s
        double ay = -9.81;  // v m/s/s

        int sirka = 40;

        double m = 100.0; //kg

        double deltaT = 0.01; // s
        CGrafPrevod prevod = new CGrafPrevod();

        public Form1()
        {
            InitializeComponent();
            //nastav grafiku
            mojaG = pictrOutput.CreateGraphics();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Ak casovac ide, zastav
            if (timerStart.Enabled)
                timerStart.Enabled = false;
            //ak nejde spusti
            else
                timerStart.Enabled = true;
            //nakresli prvu gulu cervenu

            xGraf = prevod.XmathToGraf(xFyz);
            yGraf = prevod.YMathToGraf(yFyz);
            mojaG.FillEllipse(Brushes.Red, xGraf, yGraf, sirka, sirka);

            //nastav hranice realneho priestoru a grafiky
            prevod.ZadajHraniceX(0, pictrOutput.Width, 0.0, 5000.0);
            prevod.ZadajHraniceY(0, pictrOutput.Height, 0.0, 3000.0);
            deltaT = 1.0 * timerStart.Interval / 1000.0;
        }

        private void spustac_Tick(object sender, EventArgs e)
        {
            //zmazat gulu v startej pozicii (nakresli bielu gulu
            mojaG.FillEllipse(Brushes.White, xGraf, yGraf, sirka, sirka);
            //******zmen poziciu


            //vypocitaj Fx a Fy



            //vypocitaj ax a ay
            //ax = Fx / m
            //ay = Fy / m - 9.81;


            //vypocitaj vx a xy
            vx = vx + ax * deltaT;
            vy = vy + ay * deltaT;


            //vypocitaj xFyz a yFyz
            xFyz = xFyz + vx * deltaT;
            yFyz = yFyz + vy * deltaT;



            //premen na xGraf a yGraf
            xGraf = prevod.XmathToGraf(xFyz);
            yGraf = prevod.YMathToGraf(yFyz);





            //nakresli gulu v novej pozicii(nakresli cervenu  gulu
            mojaG.FillEllipse(Brushes.Red, xGraf, yGraf, sirka, sirka);








            ////xGraf = xGraf + vx;
            //if ((xGraf >= (pbTeren.Width - sirka)) || (xGraf <= 0))
            //    vx *= -1;
            //if ((yGraf >= (pbTeren.Height - sirka)) || (yGraf <= 0))
            //    vy *= -1;
            //xGraf += vx;
            //yGraf += vy;
        }

        private void btnZrychli_Click(object sender, EventArgs e)
        {
            if (vx >= 0)
                vx++;
            else
                vx--;
            if (vy >= 0)
                vy++;
            else
                vy--;

        }

        private void btnSpomal_Click(object sender, EventArgs e)
        {
            if (vx > 0)
                vx--;
            if (vx < 0)
                vx++;
            if (vy > 0)
                vy--;
            if (vy < 0)
                vy++;

        }
    }
}
