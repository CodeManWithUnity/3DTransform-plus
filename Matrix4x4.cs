using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DTransform
{
    class Matrix4x4
    {
        private double[,] pts;
        public Matrix4x4() 
        {
            pts = new double[4, 4];
        }
        public double this[int i, int j] 
        {
            get 
            {
                return pts[i - 1, j - 1];
            }
            set 
            {
                pts[i - 1, j - 1] = value;
            }
        }
        public Matrix4x4 Mul(Matrix4x4 m) 
        {
            //矩阵相乘
            Matrix4x4 newM = new Matrix4x4();
            for (int w = 1; w <= 4; w++)
            {
                for (int h = 1; h <= 4; h++)
                {
                    for (int n = 1; n <= 4; n++)
                    {
                        newM[w, h] += this[w, n] * m[n, h];
                    }
                }
            }
            return newM;
        }

        public Vector4 Mul(Vector4 v) 
        {
            //向量相乘
            Vector4 newV = new Vector4();
            newV.X = v.X * this[1, 1] + v.Y * this[2, 1] + v.Z * this[3, 1] + v.W * this[4, 1];
            newV.Y = v.X * this[1, 2] + v.Y * this[2, 2] + v.Z * this[3, 2] + v.W * this[4, 2];
            newV.Z = v.X * this[1, 3] + v.Y * this[2, 3] + v.Z * this[3, 3] + v.W * this[4, 3];
            newV.W = v.X * this[1, 4] + v.Y * this[2, 4] + v.Z * this[3, 4] + v.W * this[4, 4];
            return newV;
        }
        //向量求转置
        public Matrix4x4 Transpose()
        {
            Matrix4x4 t = new Matrix4x4();
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    t[i, j] = this[j,i];
                }
            }
            return t;
        }

    }
}
