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
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            pictrOutput.Image = null;     
        }


        
    }
}
