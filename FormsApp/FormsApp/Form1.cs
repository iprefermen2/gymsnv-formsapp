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
            grafika.DrawEllipse(limeP, 125, 125, 150, 150);

        }
    }
}
