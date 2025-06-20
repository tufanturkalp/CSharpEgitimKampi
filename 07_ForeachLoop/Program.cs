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

            //string[] cities = { "Bangkok", "Ankara", "İstanbul", "Tiflis", "Tokyo", "Almatı", };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            //int[] numbers = { 1, 2, 456, 23, 4567, 21, 9, 23, 90, 87 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //int[] numbers = { 1, 2, 456, 23, 4567, 21, 9, 23, 90, 87 };

            //foreach (int number in numbers)
            //{
            //    if(number %2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            //int[] numbers = { 1, 2, 456, 23, 4567, 21, 9, 23, 90, 87 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            //List<int> list = new List<int>()
            //{
            //    1, 24, 678, 32, 31, 2, 9
            //};

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}


            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}




            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////Sınıftaki Öğrenci Sayısını Kullanıcıdan Alma
            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            ////Öğrenci İsimlerini ve Ortalamalarını Saklayacak Diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];
            
            //for(int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. Öğrencinin İsmini Giriniz: ");
            //    studentNames[i] = Console.ReadLine();
                
            //    Console.WriteLine() ;

            //    double totalExamResult = 0;
                
            //    //Her Öğrenci İçin 3 Sınav Notu Girişi
            //    for(int j =0; j<3;  j++)
            //    {
            //        Console.Write($"{studentNames[i]} İsimli Öğrencinin {j + 1}. Sınav Notunu Giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value; //Notları Topluyoruz
            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult / 3;

            //}

            ////Sınav Ortalamaları
            //for(int i = 0;i < studentCount;i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} Adlı Öğrencinin Ortalaması: {studentExamAvg[i]}");

            //    Console.WriteLine();

            //    //Öğrencinin Geçip Kalma Durumu
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Dersi Geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Dersten Kaldı");
            //    }

            //    Console.WriteLine();
            //}          



            #endregion
        }
    }
}
