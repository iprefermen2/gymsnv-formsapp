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
            Pen limeP = new Pen(Color.Black, 5);
            Brush maroonBrush = new SolidBrush(Color.White);

            grafika.DrawEllipse(limeP, 150, 280, 100, 100);
            grafika.FillEllipse(maroonBrush,150,280,100,100);

            grafika.DrawEllipse(limeP, 160, 200, 80, 80);
            grafika.FillEllipse(maroonBrush, 160, 200, 80, 80);

            grafika.DrawEllipse(limeP, 170, 140, 60, 60);
            grafika.FillEllipse(maroonBrush, 170, 140, 60, 60);

            grafika.DrawRectangle(limeP, 180, 100, 40, 40);
            grafika.FillRectangle(maroonBrush, 180, 100, 40, 40);

            

        }
    }
}
