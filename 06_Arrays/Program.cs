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

            //2, 4, 6, 8
            // Sarı, Kırmızı, Mavi, Turuncu
            //Ankara, İstanbul, Kayseri, Eskişehir
            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü [ ElemanSayısı ]


            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = " Mavi";

            //Console.WriteLine(colors[2]);


            //string[] cities = new string[5];
            //cities[0] = "Bangkok";
            //cities[1] = "Kyoto";
            //cities[2] = "Ulan Batur";
            //cities[3] = "Tahran";
            //cities[4] = "Ankara";

            //Console.WriteLine(cities[2]);


            //int[] numbers = new int[10];
            //numbers[0] = 2;
            //numbers[1] = 8;
            //numbers[2] = 18;
            //numbers[5] = 864;
            //numbers[9] = 10972;

            //Console.WriteLine(numbers[4]);


            //string[] cities = { "Kopenhag", "Tokyo", "Almatı", "Manila" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Kırmızı", "Mavi", "Siyah", "Beyaz", "Bordo", "Gri" };

            //for(int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] numbers = { 1, 2, 3, 87, 99, 12, 45, 94 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //char[] symbols = { 'a', 'b', 'c', '+', '/', '?' };

            //for(int i =0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] myArray = { 1, 2, 56, 435, 8, 27, 78965, 34, 3443534, 87 };

            //int maxNumber = myArray[0];

            //for(int i = 0; i< myArray.Length; i++)
            //{
            //    if(myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);                    

            #endregion

            #region Dizi Metotlar

            //string[] persons = { "Ali", "Ahmet", "Ayşe", "Fatma", "Hayriye" };

            //Console.WriteLine(persons.Length);


            //int[] numbers = { 1, 2, 54, 23, 789, 6, 342, 54, 789, 12 };

            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine("---------------");

            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //string[] customers = { "Ali", "Fatma", "Hatice", "Türkalp", "Rukiye" };

            //int index = Array.IndexOf(customers, "Hatice");

            //Console.WriteLine(index);


            //int[] numbers = { 1, 2, 54, 23, 789, 6, 342, 54, 789, 12 };

            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + " Dizinin En Küçük Elemanı: " + numbers.Min());


            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write("Lütfen Girmek İstediğiniz Şehri Yazın: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine("------------------");

            //for(int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            #endregion

            #region Örnekler

            //int[] numbers = { 10, 20, 30, 40, 50 };

            //int sum = 0;

            //for(int i  = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);


            int[] numbers = { 1, 2, 423, 12, 567, 23, 14, 890756, 23, 6565, 65453 };

            Console.WriteLine("Cift Sayılar");

            for(int i  = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2==0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("------------");

            Console.WriteLine("Tek Sayılar");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            #endregion

        }
    }
}
