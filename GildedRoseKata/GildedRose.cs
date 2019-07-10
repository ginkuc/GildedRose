using GildedRoseKata.Strategies;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                var calculateStrategy = GetStrategy(Items[i]);
                calculateStrategy.CalculateQuality(Items[i]);
            }
        }

        private static ICalculateStrategy GetStrategy(Item item)
        {
            ICalculateStrategy calculateStrategy = null;

            switch (item.Name)
            {
                case "Aged Brie":
                    calculateStrategy = new AgedBrieCalculateStrategy();
                    break;
                case "Sulfuras, Hand of Ragnaros":
                    calculateStrategy = new SulfurasCalculateStrategy();
                    break;
                case "Backstage passes to a TAFKAL80ETC concert":
                    calculateStrategy = new BackstagePassesCalculateStrategy();
                    break;
                case "Conjured Mana Cake":
                    calculateStrategy = new ConjuredCalculateStrategy();
                    break;
                default:
                    calculateStrategy = new NormalCalculateStrategy();
                    break;
            }
            return calculateStrategy;
        }
    }
}
