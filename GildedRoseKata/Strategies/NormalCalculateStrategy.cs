using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.Strategies
{
    class NormalCalculateStrategy : ICalculateStrategy
    {
        public void CalculateQuality(Item item)
        {
           
            if (item.SellIn <= 0)
            {
                item.Quality -= 2;
            }
            else if(item.SellIn > 0)
            {
                item.Quality -= 1;
            }

            if (item.Quality < 0)
                item.Quality = 0;

            item.SellIn--;
        }
    }
}
