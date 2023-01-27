﻿using System;
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            pictrOutput.Image = null;     
        }

        private void pictrOutput_MouseDown(object sender, MouseEventArgs e)
        {
            stavKreslenia = true;
            mouseOldX = e.X;
            mouseOldY = e.Y;
            kresli(e);
        }

        private void pictrOutput_MouseUp(object sender, MouseEventArgs e)
        {
            stavKreslenia = false;
        }

        private void pictrOutput_MouseMove(object sender, MouseEventArgs e)
        {      
            kresli(e);         
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            coloredPen.Color = colorDialog1.Color;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            coloredPen.Width = trackBar1.Value;
        }
    }
}
