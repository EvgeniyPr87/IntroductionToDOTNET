//#define STRING_OPERATIONS
//#define DATA_TYPS
//#define INFO_DATA_TYPS
//#define FACTORIAL
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

#if DATA_TYPS
            Console.WriteLine(sizeof(bool));
            //Console.WriteLine(Boolean.);
            bool var1;
            Boolean var2;
            //using DataType= short;
            short var3 = 0;
            Console.WriteLine($"{var3.GetType()} занимает {sizeof(short)} байт памяти и принимает значение от  {short.MinValue} ...{short.MaxValue}");
#endif

#if INFO_DATA_TYPS

            
            Console.WriteLine($"{"ЛОГИЧЕСКИЙ ТИП: "}");
            bool var4 = false;
            Console.WriteLine($"{var4.GetType().Name} занимает {sizeof(bool)} байт памяти и принимает значения {bool.FalseString}...{bool.TrueString}");

            Console.WriteLine($"{"СИМВОЛЬНЫЙ ТИП: "}");
            char varCh = '\0';
            Console.WriteLine($"{varCh.GetType()} занимает {sizeof(char)} байт памяти ");

            Console.WriteLine($"{"ЧИСЛОВОЙ ТИП: "}");
           
            byte var12 = 0;
            Console.WriteLine($"{var12.GetType()} занимает {sizeof(byte)} байт памяти и принимает значения  {byte.MinValue}...{byte.MaxValue}");
            sbyte var13 = 0;
            Console.WriteLine($"{var13.GetType()} занимает {sizeof(sbyte)} байт памяти и принимает значения {sbyte.MinValue}...{sbyte.MaxValue}");
            short var3 = 0;
            Console.WriteLine($"{var3.GetType()} занимает {sizeof(short)} байт памяти и принимает значение от  {short.MinValue} ...{short.MaxValue}");
            ushort var31 = 0;
            Console.WriteLine($"{var31.GetType()} занимает {sizeof(ushort)} байт памяти и принимает значения {ushort.MinValue}...{ushort.MaxValue}");
            int var5 = 0;
            Console.WriteLine($"{var5.GetType().Name} занимает {sizeof(int)} байт памяти и принимает значения {int.MinValue}..{int.MaxValue} ");
            uint var6 = 0;
            Console.WriteLine($"{var6.GetType()} занимает {sizeof(uint)} байт памяти и принимает значения {uint.MinValue}...{uint.MaxValue}");

            long var7 = 0;
            Console.WriteLine($"{var7.GetType()} занимает {sizeof(long)} байт памяти и принимает значения {long.MinValue}...{long.MaxValue}");

            ulong var8 = 0;
            Console.WriteLine($"{var8.GetType()} занимает {sizeof(ulong)} байт памяти и принимает значения {ulong.MinValue}...{ulong.MaxValue}");

            float var9 = 0;
            Console.WriteLine($"{var9.GetType()} занимает {sizeof(float)} байт памяти и принимает значения {float.MinValue}...{float.MaxValue}");
            
            double var10 = 0;
            Console.WriteLine($"{var10.GetType()} занимает {sizeof(double)} байт памяти и принимает значения  {double.MinValue}...{double.MaxValue}");
            decimal var11 = 0;
            Console.WriteLine($"{var11.GetType()} занимает {sizeof(decimal)} байт памяти и принимает значения {decimal.MinValue}...{decimal.MaxValue}");
            


#endif
#if FACTORIAL
            Console.SetCursorPosition(5, 0);
            Console.WriteLine("ФАКТОРИАЛ ЧИСЛА");
            Console.Write("\nВведите ваше число: ");
            float number = 0f;
            float result = 1f;
            number = Convert.ToSingle(Console.ReadLine());
            for (int i = 1; i <= number; i++) { result *= i; }
            Console.WriteLine($"\nФакториал числа {number}! = {result}"); 
#endif

        }
    }
}
