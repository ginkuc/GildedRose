using GildedRoseKata.Services;
using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class Program
    {
        private static IItemsProvider provider = new MockItemsProvider();

        public static void Main(string[] args)
        {
            var Items = provider.GetItems();
            var app = new GildedRose();

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");

                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality);
                    app.UpdateQuality(Items[j]);
                }

                Console.WriteLine("");
            }
        }
    }
}
