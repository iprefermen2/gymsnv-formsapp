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



            bool prvocislo = true;
            int number = Convert.ToInt32(txtInput.Text);


            int[] delitele = new int[2];
            int j = 0;

            for (int i = 2; i < number; i++)
            {
                delitele[0] = 1;
                
                if ((number % i) == 0) 
                { 
                    prvocislo = false;
                    j++;
                    Array.Resize(ref delitele, delitele.Length + 1);
                    delitele[j] = i;                
                }
                delitele[j + 1] = number;
            }

            if (prvocislo == true)
            {
                txtOutput.Text = "Je to prvocislo";
            }
            else if(prvocislo == false)
            {
                txtOutput.Text = "Nie je prvocislo";
            }



                string result = String.Join(",", delitele);
                labelList.Text = $"Zoznam delitelov: { result }";
            



        }
    }
}
