using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotWind3D.Model
{
    public class HW3D_Quaternion
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double W { get; set; }

        public HW3D_Quaternion(double x,double y,double z,double w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
    }
}
