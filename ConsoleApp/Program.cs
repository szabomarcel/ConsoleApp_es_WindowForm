using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static Database db = new Database();
        static List<Dolgozok> elemek = new List<Dolgozok>();
        static List<Dolgozok> Topfizetes = new List<Dolgozok>();
        static List<Dolgozok> munkakor = new List<Dolgozok>();
        static List<Dolgozok> reszleg = new List<Dolgozok>();
        //static List<Dolgozok> dolgozok = new List<Dolgozok>();
        static void Main(string[] args)
        {
            elemek = db.getAlldolgozok();
            Topfizetes = db.getAlldolgozok();
            munkakor = db.getAlldolgozok();
            reszleg = db.getAlldolgozok();
            var dolgozok = db.getAlldolgozok();
            feladat1();
            feladat2();
            feladat3();
            feladat4(dolgozok);
            Console.WriteLine("\nProgram vége!");
            Console.ReadLine();
        }

        private static void feladat4(List<Dolgozok> dolgozok)
        {
            // Adott részlegen dolgozó neve.
            Console.WriteLine("\n4. Feladat: ");
            var asztalasok = dolgozok.Where(d => d.reszleg == "asztalosműhely").Select(d => d.nev);
            Console.WriteLine("\tAz asztalosműhelyen dolgozók:");
            foreach (var nev in asztalasok)
            {
                Console.WriteLine($"\t{nev}");
            }
        }

        private static void feladat3()
        {
            // Hanya dolgoznak az adott részlegen.
            Console.WriteLine("\n3. Feladat: ");
            var munkakorokSzama = munkakor.GroupBy(d => d.reszleg).Select(group => new { Munkakor = group.Key, Darab = group.Count()});
            foreach (var munkakor in munkakorokSzama)
            {
                // Console.WriteLine($"Munkakör: {munkakor.Munkakor}, Dolgozók száma: {munkakor.Darab}");
                Console.WriteLine($"\tHányan dolgoznak az egyes részlegeken: {munkakor.Munkakor}, Dolgozók száma: {munkakor.Darab}");
            }
        }

        private static void feladat2()
        {
            Console.WriteLine("\n2. Feladat: ");
            // Kiírjuk a legmagasabb fizetéssel rendelkező dolgozó nevét.
            if (Topfizetes.Count > 0)
            {
                var maxFizetes = Topfizetes.OrderByDescending(d => d.ber).First();
                Console.WriteLine($"\tLegmagasabb fizetéssel rendelkező dolgozó: {maxFizetes.nev}");
            }
        }

        private static void feladat1()
        {
            // Elemek kiírrja a dolgozók nevét
            Console.WriteLine($"1. Feladat: Kiíratott dolgozók száma: {elemek.Count}");   
        }
    }
}
