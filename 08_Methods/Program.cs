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
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();


            //void Sum()
            //{
            //    int z = 2;
            //    int x = 1;
            //    int y = z + x;
            //    Console.WriteLine(y);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string name)
            //{
            //    Console.WriteLine(name);
            //}

            //WriteMethod("Yıldırım Doğan");


            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //CustomerCard("Ali", "Kuş");
            //CustomerCard("Ali", "Tura");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int x, int y, int z)
            //{
            //    int result = x + y + z;
            //    Console.WriteLine(result);

            //}

            //Sum(4,5,6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //Console.WriteLine(CustomerName());


            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;    
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string countrycard(string country, string capital, string flagcolors)
            //{
            //    string cardınfo = "ülke: " + country + " - başkent: " + capital + " - bayrak renkleri: " + flagcolors;

            //    return cardınfo;
            //}

            //string x, y, z;

            //Console.Write("ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("ülke başkentini giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("bayrak renklerini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine(countrycard(x, y, z));
            //Console.WriteLine(countrycard("Türkiye", "Ankara", "Kırmızı - Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 44));
            //Console.WriteLine(Sum(12, 2456));
            //Console.WriteLine(Sum(64564, 3234));
            //Console.WriteLine(Sum(1, 2));

            #endregion

            #region Örnek Uygulama

            //string ExamResult(string studentName, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;

            //    if(result >= 50)
            //    {
            //        return studentName + " İsimli Öğrenci Sınavı Geçti" + " - Ortalama: " + result; 
            //    }
            //    else
            //    {
            //        return studentName + " İsimli Öğrenci Sınavı Geçemedi" + " - Ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(ExamResult("Tufan", 55, 23, 78));
            //Console.WriteLine(ExamResult("Ali", 12, 78, 100));

            #endregion
        }
    }
}
