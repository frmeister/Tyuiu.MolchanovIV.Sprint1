using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MolchanovIV.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            return Convert.ToInt32(Math.Floor((x - Math.Truncate(x)) * 10.0));
        }
    }
}
