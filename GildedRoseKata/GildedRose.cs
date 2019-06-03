using GildedRoseKata.Services.ItemQualityProviders;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        private Dictionary<string, IItemQualityProvider> list;
        private DefaultQualityProvider defaultQualityProvider;

        public GildedRose()
        {
            list = new Dictionary<string, IItemQualityProvider>
            {
                { "Backstage passes to a TAFKAL80ETC concert", new BackstageQualityProvider() },
                { "Aged Brie", new BrieQualityProvider() },
                { "Sulfuras, Hand of Ragnaros", new SulfurQualityProvider() }
            };

            defaultQualityProvider = new DefaultQualityProvider();
        }

        public void UpdateQuality(Item item)
        {
            if(list.TryGetValue(item.Name, out var prov))
            {
                prov.UpdateQuality(item);
            }
            else
            {
                defaultQualityProvider.UpdateQuality(item);
            }
        }

        //public void UpdateQuality(Item item)
        //{
        //    if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
        //    {
        //        if (item.Quality > 0)
        //        {
        //            if (item.Name != "Sulfuras, Hand of Ragnaros")
        //            {
        //                item.Quality = item.Quality - 1;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        if (item.Quality < 50)
        //        {
        //            item.Quality = item.Quality + 1;

        //            if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
        //            {
        //                if (item.SellIn < 11)
        //                {
        //                    if (item.Quality < 50)
        //                    {
        //                        item.Quality = item.Quality + 1;
        //                    }
        //                }

        //                if (item.SellIn < 6)
        //                {
        //                    if (item.Quality < 50)
        //                    {
        //                        item.Quality = item.Quality + 1;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    if (item.Name != "Sulfuras, Hand of Ragnaros")
        //    {
        //        item.SellIn = item.SellIn - 1;
        //    }

        //    if (item.SellIn < 0)
        //    {
        //        if (item.Name != "Aged Brie")
        //        {
        //            if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
        //            {
        //                if (item.Quality > 0)
        //                {
        //                    if (item.Name != "Sulfuras, Hand of Ragnaros")
        //                    {
        //                        item.Quality = item.Quality - 1;
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                item.Quality = item.Quality - item.Quality;
        //            }
        //        }
        //        else
        //        {
        //            if (item.Quality < 50)
        //            {
        //                item.Quality = item.Quality + 1;
        //            }
        //        }
        //    }
        //}
    }
}
