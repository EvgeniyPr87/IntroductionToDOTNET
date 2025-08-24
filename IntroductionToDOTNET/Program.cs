//#define STRING_OPERATIONS
//#define DATA_TAYPS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace IntroductionToDOTNET
{
    internal class Program
    {
        class Factorial
        {
  
            public int num {  get; set; }
           

        }
        static void Main(string[] args)
        {
#if STRING_OPERATIONS
            //Console.Write("Hello .NET\n");
            //Console.Write("Привет");
            //Console.WriteLine("Hello .NET");

            Console.Write("Введите ваше имя: ");
            string first_name = Console.ReadLine();

            Console.Write("Введите вашу фамилию: ");
            string last_name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(first_name + " " + last_name + " " + age); //конкатенация строк

            Console.WriteLine(String.Format("{0} {1} {2}", first_name, last_name, age));//форматирование строк

            Console.WriteLine($"{first_name} {last_name} {age}");//интерполяция строк  
#endif

#if DATA_TAYPS
            Console.WriteLine(sizeof(bool));
            //Console.WriteLine(Boolean.);
            bool var1;
            Boolean var2;
            //using DataType= short;
            short var3 = 0;
            Console.WriteLine($"{var3.GetType()} занимает {sizeof(short)} байт памяти и принимает значение от  {short.MinValue} ...{short.MaxValue}");
#endif

          

        }
    }
}
