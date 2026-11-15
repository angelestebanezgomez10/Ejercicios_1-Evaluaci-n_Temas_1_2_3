using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciados_09
{
    internal record Punto(double X, double Y)
        public static Punto operator +(Punto a, Punto b)
    {
        return new Punto(a.X + b.X, a.Y + b.Y);
    }
}
}







