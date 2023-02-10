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
        
            

           private void btnCalculate_Click(object sender, EventArgs e) {
          

            int number = Convert.ToInt32(txtInput.Text);
            bool prvocislo = false;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) { prvocislo = false; }
                else { prvocislo = true; }

            }

            if (prvocislo = true)
            {
                txtOutput.Text = "Je to prvocislo";
            }
            else
            {
                txtOutput.Text = "Nie je prvocislo";
            }




        }
    }
}
