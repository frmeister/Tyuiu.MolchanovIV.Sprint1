using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MolchanovIV.Sprint1.Task4.V10.Lib
{
    public class DataService : ISprint1Task4V10
    {
        public double Calculate(double a)
        {
            double Degree = a * (Math.PI / 180.0); // Переводим угол с градусов на радианы

            return Math.Round(((1 + Math.Cos(Degree)) / (Math.Pow(Math.Sin(Degree), 2))), 3);
        }
    }
}
