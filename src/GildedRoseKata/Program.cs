using System;
using System.Collections.Generic;
using GildedRoseKata.Services;
using GildedRoseKata.Services.Interfaces;

namespace GildedRoseKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            var dataService = new DataService();
            var items = dataService.Load();

            var app = new GildedRose(items);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");

                foreach (var item in items)
                {
                    System.Console.WriteLine(item.Name + ", " + item.SellIn + ", " + item.Quality);
                }

                Console.WriteLine("");
                app.UpdateQuality();
            }

            Console.ReadLine();
        }
    }
}
