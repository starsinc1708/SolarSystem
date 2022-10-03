using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1lab
{
    public class Planet
    {
        public int num;
        public double Vx;
        public double Vy;
        public double x;
        public double y;
        public double picX;
        public double picY;
        public double mass;
        public int D;

        public Planet(int num, double vx, double vy, double x, double y, double mass, double d)
        {
            this.num = num;
            Vx = vx;
            Vy = vy;
            this.mass = mass;
            if(num != 0) D = (int)(Math.Log10(mass) / 2.5);
            else D = (int)(Math.Log10(mass));
            this.x = x;
            this.y = y;
        }

    }
}