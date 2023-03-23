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
        int posX = 50;
        int posY = 300;

        int sirka = 50;

        int speed = 1;

        int vx = 1;
        int vy = -1;

        int xfmin, xfmax, yfmin,yfmax;

        int gxmax, gymax;

        int vzdialenost;

        float pomerx, pomery, num;

        public Form1()
        {
            InitializeComponent();
            graphics = pictrOutput.CreateGraphics();

            xfmin = 0;
            xfmax = 200;
            yfmin = 0;
            yfmax = 100;    

            gxmax = pictrOutput.Width;
            gymax = pictrOutput.Height;

            pomerx = (xfmax-xfmin)/gxmax;
            pomery = (yfmax-yfmin)/gymax;


            vzdialenost = 100;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pictrOutput.Image = null;           
        }

        private void btnFire_Click(object sender, EventArgs e)
        {

             num = 0;
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
        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            //nastav grafiku


            //zmazat gulu 
            graphics.FillEllipse(Brushes.Khaki, posX, posY, sirka, sirka);

            //nakresli gulu novu

            if (num > 200f)
            {
                timerStart.Enabled = false;
            }
            

            if (posX >= pictrOutput.Width-sirka || posX < 0)
            {
                vx = vx * -1;
            }
            if (posY >= pictrOutput.Height-sirka || posY < 0)
            {
                vy = vy * -1;
            }

            posX += speed*vx;
            // posY += speed*vy;
            num += 1f; 
            graphics.FillEllipse(Brushes.Red, posX, posY, sirka, sirka);
        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            speed++;
        }

        private void btnBrake_Click(object sender, EventArgs e)
        {
            if(speed > 0)
            speed--;
        }
    }
}
