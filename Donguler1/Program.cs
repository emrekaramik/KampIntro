using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlama Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "python";
            string kurs5 = "c3";


            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlama Temel Kurs",
                "Java", "Python"};
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]); 
            }

            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");
           

        }
    }
}