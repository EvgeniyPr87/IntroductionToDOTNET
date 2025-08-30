using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("ВВЕДИТЕ ВЫРАЖЕНИЕ ДЛЯ ВЫЧИСЛЕНИЯ:");
            string str = Console.ReadLine();
            char[] separators = { '+', '-', '*', '/', '%', '=' };
            char sign = ' ';
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < separators.Length; j++)
                {
                    char c = str[i];
                    if (c == separators[j]) sign = separators[j];
                }

            }
                Console.WriteLine($"{sign}");
                string[] values = str.Split(separators);
                double number1 = Convert.ToDouble(values[0]);
                double number2 = Convert.ToDouble(values[1]);

                switch (sign)
                {
                    case '+': Console.WriteLine($"{number1} {sign} {number2} = {number1 + number2}"); break;
                    case '-': Console.WriteLine($"{number1} {sign} {number2} = {number1 - number2}"); break;
                    case '*': Console.WriteLine($"{number1} {sign} {number2} = {number1 * number2}"); break;
                    case '/': Console.WriteLine($"{number1} {sign} {number2} = {number1 / number2}"); break;
                }
         
        } 
    }
}
    

