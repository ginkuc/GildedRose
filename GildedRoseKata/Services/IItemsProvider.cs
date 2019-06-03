using System.Collections.Generic;

namespace GildedRoseKata.Services
{
    public interface IItemsProvider
    {
        IList<Item> GetItems();
    }
}
