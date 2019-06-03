using System.Collections.Generic;
using Xunit;

namespace GildedRoseKata
{
    public class GildedRoseTest
    {
        [Fact]
        public void UpdateQualityTest()
        {
            Item item = new Item { Name = "foo", SellIn = 0, Quality = 0 };
            GildedRose app = new GildedRose();
            app.UpdateQuality(item);
            Assert.Equal("foo", item.Name);
            Assert.Equal(-1, item.SellIn);
        }
    }
}