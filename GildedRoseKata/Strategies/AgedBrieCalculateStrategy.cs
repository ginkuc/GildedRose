using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.Strategies
{
    class AgedBrieCalculateStrategy : ICalculateStrategy
    {
        public void CalculateQuality(Item item)
        {
            item.SellIn--;

            item.Quality = (item.SellIn < 0) ? item.Quality + 2 : item.Quality + 1;

            if (item.Quality > 50)
                item.Quality = 50;
        }
    }
}
