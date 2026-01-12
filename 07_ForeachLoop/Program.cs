using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü 


            //string[] cities = {"milano","roma","ankara","budapeşte","manisa"};

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 23, 232, 554, 678, 9087, 23234, 554343 };

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}


            //int[] numbers = { 45, 23, 232, 554, 678, 9087, 23234, 554343 };

            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int[] numbers = { 45, 23, 232, 554, 678, 9087, 23234, 554343 };
            //int total = 0;

            //foreach (int number in numbers)
            //{


            //    total += number;


            //}
            //Console.WriteLine(total);   

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i); 
            //}

            //string word = "Merhaba";


            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}









            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("********* C# Eğitim Kampı Sınav Uygulama");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
 
            Console.WriteLine("--------------------------");
            Console.WriteLine("Sıfınızda kaç öğrenci var ");
            Console.WriteLine();
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------");

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin{j + 1}. sınav notunu giriniz");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                studentExamAvg[i] = totalExamResult / 3;

                Console.WriteLine();
            }
            for(int i = 0;i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
                if (studentExamAvg[i] >= 40)
                {
                    Console.WriteLine($"Tebrikler {studentNames[i]} dersten geçtin");
                }
                else {
                    Console.WriteLine($"Maalesef kaldın {studentNames[i]} korkmayın bütte daha yüksek geçircem");
                }

                Console.WriteLine("---------------------------------------------------------");
            }
       
            #endregion
        }
    }
}
