using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDesicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password=Console.ReadLine();
            //if (password == "abcd") 
            //{
            //    Console.WriteLine("Şifre Doğru");

            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;

            //Console.Write("Başkenti giriniz:");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country=Console.ReadLine(); 

            //if (capital =="ankara"& country == "türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı");

            //}
            //else
            //{
            //    Console.WriteLine("!HATALI!");
            //}

            //int sayi;
            //Console.Write("Sayıyı giriniz:");
            //sayi=int.Parse(Console.ReadLine());
            //if (sayi == 0)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("yanlış sayı!");
            //        }

            //int exam1, exam2, exam3, avarage;
            //string result="hata!" +
            //    "";

            //Console.Write("1.SINAV NOTUNUZ: ");
            //exam1=int.Parse(Console.ReadLine());

            //Console.Write("2.SINAV NOTUNUZ: ");
            //exam2=int.Parse(Console.ReadLine());

            //Console.Write("3.SINAV NOTUNUZ: ");
            //exam3=int.Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması= "+avarage);

            //if(avarage>=0 & avarage <= 50)
            //{
            //    result = "Sonuç vasat";

            //}
            //if(avarage>50 & avarage <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if(avarage>70 & avarage <= 84)
            //{
            //    result = "İyi";
            //}
            //if(avarage>84)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city=Console.ReadLine();


            //if(city=="manisa"| city == "ankara" | city == "bursa" | city == "izmir")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz");
            //string username=Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("bu kullancı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz!");
            //}






            //    Console.Read();

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;

            //Console.WriteLine(result);


            //Console.Write("Bölmek istediğiniz sayıyı giriniz : ");
            //int number1= int.Parse(Console.ReadLine());

            //Console.Write("Bölen olmasını istediğiniz sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());


            //int result = number1 % number2;
            //Console.WriteLine("Bölümden kalan : "+ result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if (number % 2 == 0) {
            //    Console.WriteLine("Sayı çifttir");

            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}
            #endregion

            #region Char Değişkenler İle Karar Yapıları
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz");
            //team=char.Parse(Console.ReadLine());

            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray(yazık)");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş(utan)");
            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("******C# Eğitim******");
            //Console.WriteLine();
            //Console.WriteLine("-------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------Ana Yemekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("---------Ana Yemekler----------");

            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------Çorbalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("3-Kellepaça Çorbası");
            //    Console.WriteLine("4-İşkembe Çorbası");
            //    Console.WriteLine("5-Tavuk Suyu Çorbası");
            //    Console.WriteLine("---------Çorbalar----------");

            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------Pizzalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margarita Pizza");
            //    Console.WriteLine("3-Bol Sucuklu Pizza");
            //    Console.WriteLine("4-Süperix Pizza");
            //    Console.WriteLine("5-Sarımsaklı Pizza");
            //    Console.WriteLine("---------Pizzalar----------");

            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------İçecekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine("4-Gazoz");
            //    Console.WriteLine("5-İce Tea");
            //    Console.WriteLine("---------İçecekler----------");

            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------Tatlılar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Künefe");
            //    Console.WriteLine("2-Tiriliçe");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("4-Magnolya");
            //    Console.WriteLine("5-Kazandibi");
            //    Console.WriteLine("---------Tatlılar----------");

            //    Console.WriteLine();
            //}






            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());


            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı Veri Girişi"); break;
            //}




            #endregion

            #region Switch Case Hesap Makinesi

            //double number1, number2, result;
            //char symbol;

            //Console.Write("Birinci Sayıyı Giriniz: ");
            //number1=double.Parse(Console.ReadLine());

            //Console.Write("İkinci Sayıyı Giriniz: ");
            //number2=double.Parse(Console.ReadLine());

            //Console.Write("Yapmak istediğiniz işlemi giriniz: ");
            //symbol=char.Parse(Console.ReadLine());


            //switch (symbol)
            //{
            //    case '+':
            //        result=number1+ number2;
            //        Console.WriteLine("Toplam: "+result);
            //        break;
            //    case '-':
            //        result=number1- number2;
            //        Console.WriteLine("Fark: "+result);
            //        break;
            //    case '/':
            //        result=number1/ number2;
            //        Console.WriteLine("Bölüm:"+result);
            //        break;
            //    case '*':
            //        result=number1*number2;
            //        Console.WriteLine("Çarpım:"+result);
            //        break;
            //}




            #endregion

            Console.Read();
        }
    }
}
