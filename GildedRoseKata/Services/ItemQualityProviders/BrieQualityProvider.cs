namespace GildedRoseKata.Services.ItemQualityProviders
{
    public class BrieQualityProvider : IItemQualityProvider
    {
        void IItemQualityProvider.UpdateQuality(Item item)
        {
            item.SellIn = item.SellIn - 1;

            if (item.Quality < 50)
            {
                item.Quality = (item.SellIn < 0) ? item.Quality + 2 : item.Quality + 1;
            }
        }
    }
}
