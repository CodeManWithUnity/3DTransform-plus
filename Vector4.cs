using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DTransform
{
    class Vector4
    {
        public double X, Y, Z, W;
        public Vector4() { }
        public Vector4(double x, double y, double z, double w) 
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
        public Vector4(Vector4 v) 
        {
            this.X = v.X;
            this.Y = v.Y;
            this.W = v.W;
            this.Z = v.Z;
        }
    }
}
