using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Mila Serbes");
            //    Console.WriteLine("Begüm Şengül");
            //    Console.WriteLine("Taner Şengül");
            //    Console.WriteLine("Rıdvan Serbes");
            //    Console.WriteLine("Meltem Serbes");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);

            //}

            //Sum();








            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar


            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Meltem Serbes");

            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " +surName);
            //}


            //CustomerCard("Meltem", "Serbes");
            //CustomerCard("Serbes", "Rıdvan");





            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int num1,int num2,int num3)
            //{

            //    int result=num1+ num2+num3;
            //    Console.WriteLine(result);

            //}

            //Sum(4, 5, 6);





            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Meltem Serbes";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name+ " "+ surname;
            //}
            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            // string CountryCard(string countryName,string capital,string flagColor)
            // {

            //     string cardInfo="Ülke: "+countryName+"  -Başkent:  "+capital+"  -Bayrak Rengi: "+flagColor;
            //     return cardInfo;

            // }
            // string x, y, z;
            // Console.Write("Ülke adını giriniz: ");

            // x = Console.ReadLine();

            // Console.Write("Ülkenin BAŞKENTİNİ giriniz: ");

            // y = Console.ReadLine();

            // Console.Write("Bayrak rengi giriniz: ");

            // z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z)); 
            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar


            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(35, 56));
            //Console.WriteLine(Sum(25, 55));
            //Console.WriteLine(Sum(15, 34));
            //Console.WriteLine(Sum(75, 87));



            #endregion

            #region Örnek Uygulama

            string ExamResult(string student,int exam1,int exam2,int exam3)
            {
                int result=(exam1+exam2+exam3)/3;
                if (result >= 50)
                {
                    return student + "isimli öĞRENCİ SINAVI GEÇTİ ";
                }
                else
                {
                    return student +"isimli öğrenci başarısız oldu ";
                }
            }

            Console.WriteLine(ExamResult("ALİ", 25, 67, 97));


            #endregion


            Console.Read();
        }
    }
}