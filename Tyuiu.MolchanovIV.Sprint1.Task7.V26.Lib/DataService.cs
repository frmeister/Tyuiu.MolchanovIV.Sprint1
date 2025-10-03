using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MolchanovIV.Sprint1.Task7.V26.Lib
{
    public class DataService : ISprint1Task7V26
    {
        public double Calculate(double x, double y)
        {
            double result = 0.0;

            result = (Math.Sin(Math.Pow(x, 2) + y) / (y + 1)); // Считаем первую дробь

            result -= ((x * y - 12) / (34 + Math.Pow(x, 2))); // Считаем вторую дробь

            return result;
        }
    }
}
