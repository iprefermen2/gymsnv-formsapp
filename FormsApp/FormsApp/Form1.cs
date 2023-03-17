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

        private void btnFire_Click(object sender, EventArgs e)
        {
            //nastartuj casovac
            if(timerStart.Enabled)
            {
                timerStart.Enabled = false;
            }
            else
            {
                timerStart.Enabled = true;
            }
            //nakresli prvu gulu
        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            //nastav grafiku

            //zmazat gulu 

            //nakresli gulu novu

        }
    }
}
