using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[3]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);





            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] olasılar = { "Ankara", "Manisa", "İzmir", "Bursa", "İstanbul" };

            //for (int i = 0; i <olasılar.Length ; i++)
            //{

            //    Console.WriteLine(olasılar[i]);

            //}

            //int[] number = { 4, 22, 34, 566, 778, 999, 1009,1233 };
            //for(int i=0;i<number.Length; i++)
            //{
            //    if(number[i] % 3 == 0)
            //    {
            //        Console.WriteLine(number[i]);

            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '$', 'z' };

            //Console.WriteLine(symbols[2]);

            //int[] myArray = { 47, 85, 95, 41, 789, 323, 434, 664 };

            //int maxValue = 0;

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (maxValue < myArray[i])
            //    {
            //        maxValue = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxValue);

            //int[] number = { 32, 34, 66, 7865, 23234, 434 };
            //Array.Sort(number);
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}

            //int[] number = { 32, 34, 66, 7865, 23234, 434 };
            //Array.Reverse(number);
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}







            #endregion

            #region Dizi Metotları 

            //string[] customers = { "ali", "buse", "ayşe", "ahmet", "hasan" };
            //int index = Array.IndexOf(customers, "ahmet");
            //Console.WriteLine(index);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine("Dizinin en küçük elemanı : "+ numbers.Max()+" Dizinin en küçük Elemanı: "+numbers.Min());


            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Eklemek istediğiniz {i + 1}.Şehri yazınız. ");
            //    cities[i] = Console.ReadLine();

            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = new int[5];
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Eklemek istediğiniz {i + 1}.sayıyı yazınız. ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < numbers.Length; i++) {

            //    sum += numbers[i];


            //}

            //Console.WriteLine(sum); 

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] tekler = new int[numbers.Length];
            int[] ciftler = new int[numbers.Length];

            int tekIndex = 0;
            int ciftIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) // Çiftse
                {
                    ciftler[ciftIndex] = numbers[i];
                    ciftIndex++;
                }
                else // Tekse
                {
                    tekler[tekIndex] = numbers[i];
                    tekIndex++;
                }
            }

            // Çıktı alırken sadece dolan elemanları yazdırmak için:
            for (int i = 0; i < tekIndex; i++)
            {
                Console.WriteLine("Tek sayı: " + tekler[i]);
            }

            for (int i = 0; i < ciftIndex; i++)
            {
                Console.WriteLine("Çift sayı: " + ciftler[i]);
            }


            #endregion

            Console.Read();
        }
    }
}
