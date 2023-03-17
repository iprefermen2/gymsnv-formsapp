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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pictrOutput.Image = null;
            graphics = pictrOutput.CreateGraphics();
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            //nastartuj casovac
            if(timerStart.Enabled)
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

            //nakresli gulu novu
            posX++;
            posY--;
            graphics.FillEllipse(Brushes.Red, posX, posY, 50, 50);
        }
    }
}
