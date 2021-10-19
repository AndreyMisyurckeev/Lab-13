using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiBilding multiBilding = new MultiBilding("Prospect Mira", 350, 50, 60, 20);
            multiBilding.Print();
            Console.ReadKey();
        }
    }
    public class Building
    {
        public string Adress { get; set; }
        public int Llong { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Building(string adress, int llong, int width, int height)
        {
            Adress = adress;
            Llong = llong;
            Width = width;
            Height = height;
        }
        public Building()
        {
        }
        public void Print()
        {
            Console.WriteLine($"Adress: {Adress}");
            Console.WriteLine($"Long: {Llong}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Height: {Height}");
        }
    }
    public sealed class MultiBilding : Building
    {
        public int Floor { get; set; }
        public MultiBilding(string adress, int llong, int width, int height, int floor) : base(adress, llong, width, height)
        {
            Floor = floor;
        }
        public void Print()
        {
            Console.WriteLine($"Adress: {Adress};");
            Console.WriteLine($"Long: {Llong} m;");
            Console.WriteLine($"Width: {Width} m;");
            Console.WriteLine($"Height: {Height} m;");
            Console.WriteLine($"Floor: {Floor} m;");
        }
    }
}

