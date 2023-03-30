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

        private Point arrowStart;

        Graphics graphics;
        CGrafPrevod conversion = new CGrafPrevod();


        int posX = 50;
        int posY = 300;

        double fposx = 100;
        double fposy = 100;


        double interval = 0.01;


        int sirka = 50;


        double vx = 100;
        double vy = 200;

        double ax = 0;
        double ay = 9.81;

        int m = 1;

        double Fx = 0.0; 
        double Fy = -9.81;

        double firstClickX = 0;
        double firstClickY = 0;
        bool isClicked = false;
        

        double xspeed,yspeed,dx,dy;

        public Form1()
        {
            InitializeComponent();
            graphics = pictrOutput.CreateGraphics();
            conversion.ZadajHraniceX(0, pictrOutput.Width, 0, 5000);
            conversion.ZadajHraniceY(0, pictrOutput.Height, 0, 3000);
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
            posX = conversion.XmathToGraf(fposx);
            posY = conversion.YMathToGraf(fposy);
            graphics.FillEllipse(Brushes.Red, posX, posY, 50, 50);

            //hraniciari          
            conversion.ZadajHraniceX(0, pictrOutput.Width, 0, 5000);
            conversion.ZadajHraniceY(0,pictrOutput.Height,0,3000);
            interval = (double)timerStart.Interval / 1000;


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
            double ax = Fx / m; // m is the mass of the ball
            double ay = Fy * m;

            
            //rychlost
            vx += ax * interval;
            vy += ay * interval;
            Console.WriteLine($"vy: {vy}");


            //vypocitaj xFyz a zFyz
            fposx += vx * interval;
            fposy += vy * interval;

            Console.WriteLine($"fposy: {fposy}");
            Console.WriteLine($"speed: {xspeed}");
            Console.WriteLine($"speed: {yspeed}");
            Console.WriteLine($"dx: {dx}");
            Console.WriteLine($"dy: {dy}");




            //premen na xGraf a yGraf
            posX = conversion.XmathToGraf(fposx);
            posY = conversion.YMathToGraf(fposy);











            //17.3
            //posX += vx;
            //posY += vy;
            graphics.FillEllipse(Brushes.Red, posX, posY, sirka, sirka);
        }
        private void pictrOutput_MouseMove(object sender, MouseEventArgs e)
        {
            
                if (isClicked)
                {
                    pictrOutput.Invalidate();
                    
                    Pen pen = new Pen(Brushes.Lime, 5);
                    graphics.DrawLine(pen, arrowStart, e.Location);
                }
            
        }

        private void btnAccelerate_Click(object sender, EventArgs e)
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

        private void btnBrake_Click(object sender, EventArgs e)
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

        
        



        private void pictrOutput_MouseClick(object sender, MouseEventArgs e)
        {          
            if (isClicked == false)
            {
                arrowStart = e.Location;
                isClicked = true;

                
                // First click, record position
                firstClickX = conversion.XgrafToMath(e.X);

                firstClickY = conversion.YGrafToMath(e.Y);
                isClicked = true;
            }
            else
            {
                graphics.DrawLine(Pens.Khaki, arrowStart, e.Location);
                // Second click, calculate direction and speed
                double secondClickX = conversion.XgrafToMath(e.X);
                double secondClickY = conversion.YGrafToMath(e.Y);
               

                dx = secondClickX - firstClickX;
                dy = secondClickY - firstClickY;
                double distance = Math.Sqrt(dx * dx + dy * dy);

                double directionX = dx / distance;
                double directionY = dy / distance;


                double speed = distance / 10; // adjust factor as needed

                vx = speed * directionX;
                vy = speed * directionY;

                // adjust factor as needed

                //vx = xspeed * directionX;
                //vy = yspeed * directionY;

                isClicked = false;
            }
        }

    }
}
