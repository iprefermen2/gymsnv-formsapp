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
        bool stavKreslenia = false;
        int mouseOldX = 0;
        int mouseOldY = 0;

        Pen coloredPen = new Pen(Color.Lime, 2);
        public Form1()
        {
            //pri vzniku okna
            InitializeComponent();
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            pictrOutput.Image = null;     
        }



        private void btnPaint_Click(object sender, EventArgs e)
        {

            float x1 = 0;
            float y1 = 0;

            float y2 = 0;
            float top = 200;

            float eX = 20; //size multiplayer
            float eY = 200;

            Graphics grafika = pictrOutput.CreateGraphics();

            for (float x = 0; x < 400; x += 0.1F)
            {
                y2 = (float)Math.Sin(x);

                grafika.DrawLine(coloredPen, x1*eX , y1*eX  + top, x*eX,  y2 *eX + top);

                x1 = x;
                y1 = y2;
            }
                                                      
        }
    }
}
