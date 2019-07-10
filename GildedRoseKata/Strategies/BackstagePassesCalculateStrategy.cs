using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.Strategies
{
    class BackstagePassesCalculateStrategy : ICalculateStrategy
    {
        public void CalculateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;

                if (item.SellIn < 11)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
                if (item.SellIn < 6)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }

            item.SellIn--;

            if (item.SellIn < 0)
                item.Quality = item.Quality - item.Quality;
        }
    }
}
