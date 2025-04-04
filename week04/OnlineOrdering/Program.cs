using System;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("\n >\n >\n >");

        Order order1 = new Order();
        order1.SetOrder("Tayler", "123, 101st Str, Phoenix, AZ, USA");
        order1.AddProduct("Sock", "0001", 0.90, 10);
        order1.AddProduct("Shoe", "0002", 34.80, 2);
        order1.AddProduct("Hat", "0003", 11.50, 1);
        order1.ReturnPackingLabel();
        order1.ReturnShippingLabel();
        
        Console.WriteLine("\n >\n >\n >");

        Order order2 = new Order();
        order2.SetOrder("Taylor", "345, 7th Rd, Phoenix, AZ, US");
        order2.AddProduct("Common Card", "0004", 0.12, 13);
        order2.AddProduct("Mythic Card", "0005", 15, 2);
        order2.AddProduct("Rare Card", "0006", 8.5, 4);
        order2.ReturnPackingLabel();
        order2.ReturnShippingLabel();
        
        Console.WriteLine("\n >\n >\n >");

        Order order3 = new Order();
        order3.SetOrder("Rachael", "678, Awesome Ave, Phoenix, AZ, United States of America");
        order3.AddProduct("Small Pot", "0007", 8.54, 8);
        order3.AddProduct("Large Pot", "0008", 34.80, 3);
        order3.AddProduct("Top Soil", "0009", 31.22, 2);
        order3.ReturnPackingLabel();
        order3.ReturnShippingLabel();

        Console.WriteLine("\n >\n >\n >");

                Order order4 = new Order();
        order4.SetOrder("Rachael", "678, Awesome Ave, Phoenix, AZ, Zimbabwe");
        order4.AddProduct("Small Pot", "0007", 8.54, 8);
        order4.AddProduct("Large Pot", "0008", 34.80, 3);
        order4.AddProduct("Top Soil", "0009", 31.22, 2);
        order4.ReturnPackingLabel();
        order4.ReturnShippingLabel();
        
    }
}