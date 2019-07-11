using GildedRoseKata.Strategies;
using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            var data = DataHelper.GetSomeData();

            var app = new GildedRose(data);


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < data.Count; j++)
                {
                    System.Console.WriteLine(data[j].Name + ", " + data[j].SellIn + ", " + data[j].Quality);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }

        
    }
}
