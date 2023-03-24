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
        Graphics graphics;
        CGrafPrevod conversion = new CGrafPrevod();


        int posX = 50;
        int posY = 300;

        double fposx = 100;
        double fposy = 100;

        double fspeed = 0;
        double interval = 0.01;


        int sirka = 50;

        int speed = 1;

        double vx = 100;
        double vy = 200;

        double ax = 0;
        double ay = 9.81;


        public Form1()
        {
            InitializeComponent();
            graphics = pictrOutput.CreateGraphics();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pictrOutput.Image = null;           
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            //nastartuj casovac
            if (timerStart.Enabled)
            {
                timerStart.Enabled = false;
            }
            else
            {
                timerStart.Enabled = true;
            }
            //nakresli prvu gulu
            graphics.FillEllipse(Brushes.Red, posX, posY, 50, 50);

            //hraniciari 
            interval = (double)timerStart.Interval / 1000;
            conversion.ZadajHraniceX(0, pictrOutput.Width, 0, 5000);
            conversion.ZadajHraniceY(0,pictrOutput.Height,0,3000);


        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            //nastav grafiku
            

            //zmazat gulu 
            graphics.FillEllipse(Brushes.Khaki, posX, posY, sirka, sirka);

            //nakresli gulu novu

            //24.3--------------------------------------------------------------------------------------------------------------
            //zrychlenie
            //vx = v cosalfa


            

            //rychlost
            vx = vx + ax * interval;
            vy = vy + ay * interval;


            //vypocitaj xFyz a zFyz
            fposx = fposx + vx * interval;
            fposy = fposy + vy * interval;


            //premen na xGraf a yGraf
            posX = conversion.XmathToGraf(fposx);
            posY = conversion.YMathToGraf(fposy);











            //17.3
            //posX += vx;
            //posY += vy;
            graphics.FillEllipse(Brushes.Red, posX, posY, sirka, sirka);
        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            vx++;
        }

        private void btnBrake_Click(object sender, EventArgs e)
        {
            if(speed > 0)
            vx--;
        }
    }
}
