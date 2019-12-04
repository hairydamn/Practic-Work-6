using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.Найти кол-во цифр в числе их сумму и произведение. */

            /* Console.WriteLine("Vvedite chislo");
             int a = Convert.ToInt32(Console.ReadLine());
             string num = a.ToString();
             int sum = 0;
             int pr = 1;
             int i = 0;
             while(i < num.Length)
             {
                 Console.WriteLine(num.Substring(i, 1));
                 sum += Convert.ToInt32(num.Substring(i, 1));
                 pr *= Convert.ToInt32(num.Substring(i, 1));
                 i++;
             }
             Console.WriteLine("Sum");
             Console.WriteLine(sum);
             Console.WriteLine("PR");
             Console.WriteLine(pr);
             Console.ReadKey();*/

            /*2. Считать сумму и произведение введенных с клавиатуры чисел  до тех пор, пока не будет введен ноль. */

            /*Console.WriteLine("Vvedite chisla");
            int coi = 0;
            double lizer = 1;
            int pivo = -1;
            while (pivo != 0)
            {
                pivo = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
                Console.WriteLine();
                coi += pivo;
                lizer *= pivo;
                Console.WriteLine("Sum: " + coi);
                Console.WriteLine("Pr: " + lizer);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Sum: " + coi);
            Console.WriteLine("Pr: " + lizer);*/


            /*3. Организовать беспрерывный ввод чисел с клавиатуры, пока пользователь не введёт 0. После ввода нуля, показать на экран количество чисел, которые были введены, их общую сумму и среднее арифметическое.*/

            /*Console.WriteLine("Vvedite chisla");
            int sum = 0;
            double srarifm = 0;
            int count = 0;
            int pivo = -1;
            while (pivo != 0)
            {
                pivo = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
                if (pivo != 0)
                {
                    count++;
                }
                Console.WriteLine();
                sum += pivo;
                srarifm = Convert.ToDouble(sum) / Convert.ToDouble(count);
                
            }
            Console.WriteLine("Среднее арифметическое: " + srarifm);
            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Количество ввиденных цифр: " + count);
            Console.ReadKey();*/

            /*4. Необходимо суммировать все нечётные целые числа в диапазоне, который введёт пользователь с клавиатуры. */

            /*Console.WriteLine("Vvedite 2 chisla");
            int sum = 0;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            while (a < b)
            {
                if (a % 2 != 0)
                {
                    sum += a;
                }
                a++;
            }
            Console.WriteLine(sum);

            Console.ReadKey();*/

            
            /* 5. Загадать пользователю загадку. В случае неверного ответа, заново задать загадку.  */
            Random rnd = new Random();
            int flag = rnd.Next(1, 100);

            while (flag != 0)
            {
                flag = rnd.Next(1, 100);
                int a = rnd.Next(-100, 100 + rnd.Next(flag * 1 , flag * 2));
                int b = rnd.Next(-100, a + rnd.Next(Convert.ToInt32(1 * 0.5), Convert.ToInt32(100 * 0.75)));
                Console.WriteLine("Сколько будет {0} + {1}", a, b);
                if (Convert.ToInt32(Console.ReadLine()) == a + b)
                {
                    Console.WriteLine("Правильно");
                    flag = 0;
                    break;
                }
                else
                {
                    Console.WriteLine("Неправильно");
                }
            }
            Console.ReadKey();

            
            
        }
    }
}
