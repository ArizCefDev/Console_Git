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

            Drink dr = new Drink();
            dr.Name = "Pepsi";
            dr.Weight = 1;  
            dr.Stock = 100;
            dr.Price = 1.19;
            dr.Show();  

            Snack sn = new Snack();
            sn.Name = "Peanuts";
            sn.Weight = 0.500;
            sn.Stock = 2;
            sn.Price = 15;
            sn.Show();  

        }
    }
}
