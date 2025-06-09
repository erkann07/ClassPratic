using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using ConsoleApp20;

namespace ConsoleApp20
{
    internal class BaseKisi
    {
        public string FName { get; set; }
        public string LName { get; set; }
    }

    internal class Ogrenci : BaseKisi
    {
        public string StudentNumber { get; set; }
        public Ogrenci(string ad, string soyad, string no)
        {
            Console.WriteLine($"Öğrenci Adı:{ad} \nÖğrenci Soyadı:{soyad}");
            Console.WriteLine($"Öğrenci Numarası:{no}");
        }
    }

    internal class Ogretmen : BaseKisi
    {
        public int Maas { get; set; }
        public Ogretmen(string ad, string soyad, int Maas)
        {
            Console.WriteLine($"Öğretmen Adı: {ad} \nÖğretmen Soyadı: {soyad}");
            Console.WriteLine($"Maaş : {Maas}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aşağıda 1 öğrencinin bilgileri verilmiştir.");
            Ogrenci ogrenci = new Ogrenci("Ali", "Yılmaz", "123");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Aşağıda 1 öğretmenin bilgileri verilmiştir");
            Ogretmen ogretmen = new Ogretmen("Ayşe", "Demir", 5000);
        }
    }
}