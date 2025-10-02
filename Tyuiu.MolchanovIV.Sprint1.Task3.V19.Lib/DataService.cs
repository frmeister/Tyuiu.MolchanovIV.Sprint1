using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MolchanovIV.Sprint1.Task3.V19.Lib
{
    public class DataService : ISprint1Task3V19
    {
        public bool ElephCanMove(double x1, double x2, double y1, double y2)
        {
            if (x2 > x1)
            {
                if (y2 > y1)
                {
                    if ((x2 == (x1 + 2)) && (y2 == (y1 + 1))) return true;
                    if ((x2 == (x1 + 1)) && (y2 == (y1 + 2))) return true;
                } else
                {
                    if ((x2 == (x1 + 2)) && (y2 == (y1 - 1))) return true;
                    if ((x2 == (x1 + 1)) && (y2 == (y1 - 2))) return true;
                }
            } else
            {
                if (y2 > y1)
                {
                    if ((x2 == (x1 - 2)) && (y2 == (y1 + 1))) return true;
                    if ((x2 == (x1 - 1)) && (y2 == (y1 + 2))) return true;
                }
                else
                {
                    if ((x2 == (x1 - 2)) && (y2 == (y1 - 1))) return true;
                    if ((x2 == (x1 - 1)) && (y2 == (y1 - 2))) return true;
                }
            }
                return false;
        }
    }
}
