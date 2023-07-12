using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsuletion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Handphone hp1 = new Handphone();
            hp1.Hp = "Android";
            hp1.Merk = "Odoo";
            hp1.Emei = "1244-4623-7654";

            Console.WriteLine($"Type Handphone : {hp1.Hp}" + "\n" + $"Merk Handphone : {hp1.Merk}" + "\n" + $"Nomor Emei : {hp1.Emei}");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");

            Handphone hp2 = new Handphone();
            hp2.SetHandphone("Iphone", "Iphone 14 Promag");
            hp2.SetEmei("4823-7765-3246");
            Console.WriteLine(hp2);

            Console.ReadKey();
        }
    }
}