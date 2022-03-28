using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionsProcessor
{
    //Класс содержащий точки и математические коэффициенты отрезков
    public class Segment
    {
        public Point P1 { get; }
        public Point P2 { get; }
        //Коэффициент наклона прямой к оси OX
        public double K { get; }
        //Коэффициент сдвига прямой вдоль оси OY
        public double D { get; }
        
        public bool IsSplitted { get; set; }

        //Потомки отрезка, сюда записываются отрезки, на которые был разделен родительский отрезок
        public Segment FirstDerivative { get; set; }
        public Segment SecondDerivative { get; set; }

        public Segment(int X1, int X2, int Y1, int Y2)
        {
            P1 = new Point(X1, Y1);
            P2 = new Point(X2, Y2);

            K = (double)(Y2 - Y1) / (X2 - X1);
            D = (double)(X2 * Y1 - X1 * Y2) / (X2 - X1);

            IsSplitted = false;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Segment))
            {
                return false;
            }
            if(this.P1 == ((Segment)obj).P1 && this.P2 == ((Segment)obj).P2)
                return true;
            return false;
        }
    }
}
