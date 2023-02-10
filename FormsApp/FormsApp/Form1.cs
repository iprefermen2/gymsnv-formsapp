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

        Pen coloredPen = new Pen(Color.Lime, 20);
        public Form1()
        {
            //pri vzniku okna
            InitializeComponent();
        }

        public void kresli(MouseEventArgs e)
        {
            Graphics grafika = pictrOutput.CreateGraphics();
            //Random rnd = new Random();
           
            int  mouseFetchX, mouseFetchY;
            

            mouseFetchX = e.X;
            mouseFetchY = e.Y;

            if (stavKreslenia == true)
            {
                grafika.DrawLine(coloredPen, mouseOldX, mouseOldY, mouseFetchX, mouseFetchY);
            }
            mouseOldX = mouseFetchX;
            mouseOldY = mouseFetchY;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pictrOutput.Image = null;     
        }



        private void btnPaint_Click(object sender, EventArgs e)
        {
            

                Graphics grafika = pictrOutput.CreateGraphics();
                Random rnd = new Random();




                Pen limeP = new Pen(Color.Lime, 10);




            Brush maroonBrush = new SolidBrush(Color.White);
            var brush = maroonBrush as SolidBrush;

            int size = pictrOutput.Width;
                int sizeExtension = size / 8;
                    for(int i = 0; i <= 8; i++)
                    {
                if(i % 2 == 0)
                {
                    brush.Color = Color.Red;
                }
                else
                {
                     brush.Color =  Color.Blue;
                }

                // limeP.Color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                //grafika.DrawRectangle(limeP, 0, 0, sizeExtension, sizeExtension );
                //maroonBrush.Color 
                //brush = new SolidBrush(Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
                grafika.FillRectangle(brush, sizeExtension*i, 0, sizeExtension, sizeExtension);
                //grafika.FillRectangle(maroonBrush, 0, 0, sizeExtension * i, sizeExtension * i);

                }       
                     
        }
    }
}
