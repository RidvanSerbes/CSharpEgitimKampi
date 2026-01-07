using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları


            ////Console.WriteLine("Merhaba Dünya");
            ////Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Salatalar");
            //Console.WriteLine("4-Ara sıcaklar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");

            #endregion
            #region String Değişkenler

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Rıdvan";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail,distict,city;

            //customerName = "Meltem";
            //customerSurname = "Mersinoğlu";
            //customerPhone = "+90 5065376904";
            //customerEmail = "ridvanserbes10@gmail.com";
            //distict = "Çukurambar";
            //city = "Ankara";

            //Console.WriteLine("*****Rezervasyon Kartı*****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:"+customerPhone+"  MAİL:"+customerEmail);
            //Console.WriteLine("Adres: " + distict+"/"+city);
            //Console.WriteLine("---------------------------");

            //Console.WriteLine();

            //customerName = "Begüm";
            //customerSurname = "Şengül";
            //customerPhone = "+90 0555 666 77 88";
            //customerEmail = "deneme@gmail.com";
            //distict = "Merkezefendi";
            //city = "Manisa";
            //Console.WriteLine(customerName);
            //Console.WriteLine("---------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone + "  MAİL:" + customerEmail);
            //Console.WriteLine("Adres: " + distict + "/" + city);
            //Console.WriteLine("---------------------------");



            #endregion
            #region Int Değişkenler

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("-----Kola = "+ cokePrice+" TL ");
            Console.WriteLine("-----Pizza = "+ pizzaPrice+" TL ");
            Console.WriteLine("-----Hamburger= "+ hamburgerPrice+" TL ");
            Console.WriteLine("-----Limonata = "+ lemonadePrice+" TL ");
            Console.WriteLine("-----SU = "+ waterPrice+" TL ");
            Console.WriteLine() ;
            Console.WriteLine("***** Restoran Menü Fiyatı *****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int pizzaCount;
            int lemonadeCount;

            int totalPrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            pizzaCount = 0;
            lemonadeCount = 0;
            totalPrice = (hamburgerCount*hamburgerPrice)+(cokeCount*cokePrice)+(waterCount*waterPrice)+(pizzaCount*pizzaPrice)+(lemonadeCount*lemonadePrice);

            Console.WriteLine("---------------");
            Console.WriteLine("Toplam hesabınız : "+totalPrice+" TL");
                


            #endregion





            Console.Read();
        }
    }
}


//Yazdırma Komutları