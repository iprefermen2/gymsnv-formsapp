using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApp
{
    public class ScaleConverter
    {
        private double min_fyz_x, max_fyz_x, min_graf_x, max_graf_x;
        private double min_fyz_y, max_fyz_y, min_graf_y, max_graf_y;

        public void setTheBorderX(double min_fyz_x, double max_fyz_x, double min_graf_x, double max_graf_x)
        {
            this.min_fyz_x = min_fyz_x;
            this.max_fyz_x = max_fyz_x;
            this.min_graf_x = min_graf_x;
            this.max_graf_x = max_graf_x;
        }

        public void setTheBorderY(double min_fyz_y, double max_fyz_y, double min_graf_y, double max_graf_y)
        {
            this.min_fyz_y = min_fyz_y;
            this.max_fyz_y = max_fyz_y;
            this.min_graf_y = min_graf_y;
            this.max_graf_y = max_graf_y;
        }

        public double convertFyzXToGrafX(double fyz_x)
        {
            double graf_x = ((fyz_x - min_fyz_x) / (max_fyz_x - min_fyz_x)) * (max_graf_x - min_graf_x) + min_graf_x;
            return graf_x;
        }

        public double convertGrafXToFyzX(double graf_x)
        {
            double fyz_x = ((graf_x - min_graf_x) / (max_graf_x - min_graf_x)) * (max_fyz_x - min_fyz_x) + min_fyz_x;
            return fyz_x;
        }

        public double convertFyzYToGrafY(double fyz_y)
        {
            double graf_y = ((fyz_y - min_fyz_y) / (max_fyz_y - min_fyz_y)) * (max_graf_y - min_graf_y) + min_graf_y;
            return graf_y;
        }

        public double convertGrafYToFyzY(double graf_y)
        {
            double fyz_y = ((graf_y - min_graf_y) / (max_graf_y - min_graf_y)) * (max_fyz_y - min_fyz_y) + min_fyz_y;
            return fyz_y;
        }
    }


}
