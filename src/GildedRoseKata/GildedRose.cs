using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        readonly IList<Item> _items;

        public GildedRose(IList<Item> items)
        {
            this._items = items ?? throw new ArgumentNullException(nameof(items));
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                if(!IsAgedBrie(item.Name) || !IsPassesTAFKAL80ETC(item.Name))
                {
                    if (item.Quality > 0)
                    {
                        if (!IsSulfurasHandOfRagnaros(item.Name))
                        {
                            item.Quality = item.Quality - 1;
                        }
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;

                        if (IsPassesTAFKAL80ETC(item.Name))
                        {
                            if (item.SellIn < 11)
                            {
                                IncresseQuality(item);
                            }

                            if (item.SellIn < 6)
                            {
                                IncresseQuality(item);
                            }
                        }
                    }
                }

                if (!IsSulfurasHandOfRagnaros(item.Name))
                {
                    item.SellIn = item.SellIn - 1;
                }

                if (item.SellIn < 0)
                {
                    if (!IsAgedBrie(item.Name))
                    {
                        if (!IsPassesTAFKAL80ETC(item.Name))
                        {
                            if (item.Quality > 0)
                            {
                                if (!IsSulfurasHandOfRagnaros(item.Name))
                                {
                                    item.Quality = item.Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            item.Quality = item.Quality - item.Quality;
                        }
                    }
                    else
                    {
                        IncresseQuality(item);
                    }
                }
            }
        }

        //Future move to Extensions
        private static bool IsPassesTAFKAL80ETC(string name)
        {
            return name == "Backstage passes to a TAFKAL80ETC concert";
        }

        private static bool IsAgedBrie(string name)
        {
            return name == "Aged Brie";
        }

        public static bool IsSulfurasHandOfRagnaros(string name)
        {
            return name == "Sulfuras, Hand of Ragnaros";
        }

        public void IncresseQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
        }
    }
}
