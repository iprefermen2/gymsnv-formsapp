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
        public Form1()
        {
            //pri vzniku okna
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            Graphics grafika = pictrOutput.CreateGraphics();
            Random rnd = new Random();




            Pen limeP = new Pen(Color.Lime, 10);



            //Brush maroonBrush = new SolidBrush(Color.White);

            kresliAjajaj();

            void kresliAjajaj()
            {
                int size = pictrOutput.Width;
                int sizeExtension = size / 10;

                for (int i = 11; i >= 1; i--)
                {
                    limeP.Color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                    grafika.DrawRectangle(limeP, 0, 0, sizeExtension*i, sizeExtension*i);
                    //maroonBrush.Color 
                    Brush maroonBrush = new SolidBrush(Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
                    grafika.FillRectangle(maroonBrush, 0, 0, sizeExtension * i, sizeExtension * i);
                    //grafika.FillRectangle(maroonBrush, 0, 0, sizeExtension * i, sizeExtension * i);
                }
            }
            
void kresliAjajaj2()
            {
                int size = pictrOutput.Width;
                int sizeExtension = size / 10;

                for (int i = 0; i <= 10; i++)
                {
                    limeP.Color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                    grafika.DrawRectangle(limeP, 0+(sizeExtension*i), 0, size-(sizeExtension*i), size-(sizeExtension*i));
                    //maroonBrush.Color 
                    Brush maroonBrush = new SolidBrush(Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
                    grafika.FillRectangle(maroonBrush, 0, 0, sizeExtension * i, sizeExtension * i);
                    //grafika.FillRectangle(maroonBrush, 0, 0, sizeExtension * i, sizeExtension * i);
                }
            }
void kresliAjajaj3()
            {
                int size = pictrOutput.Width;
                int sizeExtension = size / 10;

                for (int i = 0; i <= 10; i++)
                {
                    limeP.Color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                    grafika.DrawRectangle(limeP, 0+(sizeExtension*i), 0+(sizeExtension*i), size-(sizeExtension*i), size-(sizeExtension*i));
                    //maroonBrush.Color 
                    Brush maroonBrush = new SolidBrush(Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
                    grafika.FillRectangle(maroonBrush, 0, 0, sizeExtension * i, sizeExtension * i);
                    //grafika.FillRectangle(maroonBrush, 0, 0, sizeExtension * i, sizeExtension * i);
                }
            }
void kresliAjajaj4()
            {
                int size = pictrOutput.Width;
                int sizeExtension = size / 10;

                for (int i = 0; i <= 10; i++)
                {
                    limeP.Color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                    grafika.DrawRectangle(limeP, 0, 0+(sizeExtension*i), size-(sizeExtension*i), size-(sizeExtension*i));
                    //maroonBrush.Color 
                    Brush maroonBrush = new SolidBrush(Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
                    grafika.FillRectangle(maroonBrush, 0, 0, sizeExtension * i, sizeExtension * i);
                    //grafika.FillRectangle(maroonBrush, 0, 0, sizeExtension * i, sizeExtension * i);
                }
            }

        }
    }
}
