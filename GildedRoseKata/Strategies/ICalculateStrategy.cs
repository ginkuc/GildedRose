using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.Strategies
{
    interface ICalculateStrategy
    {
        void CalculateQuality(Item item);
    }
}
