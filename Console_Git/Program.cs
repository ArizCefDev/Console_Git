using System;

namespace Console_Git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meat mt = new Meat();
            mt.Name = "Beylaqan";
            mt.Weight = 1;
            mt.Stock = 500;
            mt.Price = 11.5;
            mt.Show();
        }
    }
}
