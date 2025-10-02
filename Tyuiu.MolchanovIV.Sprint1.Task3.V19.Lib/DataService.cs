using System.Runtime.Serialization;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MolchanovIV.Sprint1.Task3.V19.Lib
{
    public class DataService : ISprint1Task3V19
    {
        public bool ElephCanMove(double x1, double x2, double y1, double y2)
        {
            double z;  // Расстояние которое преодолел слон по Х
            if (x2 > x1)
            {
                z = x2 - x1;
                if (y2 > y1)

                    if ((y2 - y1) == z) return true;
                    else if ((y1 - y2) == z) return true;

            }
            else
            {
                z = x1 - x2;
                if (y2 > y1)

                    if ((y2 - y1) == z) return true;
                    else if ((y1 - y2) == z) return true;
            }
                return false;
        }
    }
}
