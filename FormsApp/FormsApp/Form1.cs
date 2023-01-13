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

        private void buttonInput_Click(object sender, EventArgs e)
        {
            string vstupnyText = textBoxInput.Text;
            string vystupnyText = textBoxOutput.Text;
            this.textBoxOutput.Text = vstupnyText;
            this.textBoxInput.Text = vystupnyText;
        }

        private void textBoxInput_MouseHover(object sender, EventArgs e)
        {
            this.textBoxInput.BackColor = Color.DarkOliveGreen;
        }
    }
}
