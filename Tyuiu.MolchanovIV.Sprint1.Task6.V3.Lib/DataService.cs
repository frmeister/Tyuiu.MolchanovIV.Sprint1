using System.Runtime.CompilerServices;
using System.Security;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MolchanovIV.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        {
            string result = "";
            char ch;
            int Counter = 0;

            while (Counter < (value.Length - 1))
            {

                    if (value[Counter + 1] == ' ')
                    {
                            result += value[Counter];
                    }

                Counter++; 
            }

            if (value[value.Length - 1] != ' ') result += value[value.Length - 1];
            else result += value[value.Length - 2]; // Если последний символ пустой, ставим как последнее значение result последнюю букву в тексте

                return result;
        }
    }
}
