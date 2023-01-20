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

            

            Pen limeP = new Pen(Color.Lime, 10);



            Brush maroonBrush = new SolidBrush(Color.White);
            kresliAjajaj();

            void kresliAjajaj()
            {
                int size = pictrOutput.Width;
                int sizeExtension = size / 10;

                for (int i = 0; i <= 10; i++)
                {
                    grafika.DrawRectangle(limeP, 0, 0, sizeExtension*i, sizeExtension*i);
                    //grafika.FillRectangle(maroonBrush, 0, 0, sizeExtension * i, sizeExtension * i);
                }
            }

            

        }
    }
}
