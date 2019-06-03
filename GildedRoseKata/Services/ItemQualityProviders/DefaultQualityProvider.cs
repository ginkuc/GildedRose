namespace GildedRoseKata.Services.ItemQualityProviders
{
    public class DefaultQualityProvider : IItemQualityProvider
    {
        public void UpdateQuality(Item item)
        {
            if (item.SellIn > 0)
            {
                item.Quality--;
            }
            if(item.SellIn <= 0)
            {
                item.Quality -= 2;
            }

            item.SellIn--;
        }
    }
}
