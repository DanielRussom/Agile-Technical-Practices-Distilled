using Agile_Technical_Practices_Distilled.Chapter_9;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_9
{
    [TestClass]
    public class GildedRoseShould
    {
        [TestMethod]
        public void Lower_foo_SellIn()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            var resultItem = Items[0];
            Assert.AreEqual("foo", resultItem.Name);
            Assert.AreEqual(-1, resultItem.SellIn);
            Assert.AreEqual(0, resultItem.Quality);
        }

        //Unique cases: Aged Brie, Backstage passes to a TAFKAL80ETC concert, Sulfuras, Hand of Ragnaros
    }
}
