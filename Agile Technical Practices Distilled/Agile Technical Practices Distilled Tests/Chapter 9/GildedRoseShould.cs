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

        [TestMethod]
        public void Increase_aged_brie_quality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            var resultItem = Items[0];
            Assert.AreEqual("Aged Brie", resultItem.Name);
            Assert.AreEqual(1, resultItem.SellIn);
            Assert.AreEqual(1, resultItem.Quality);
        }

        [TestMethod]
        public void Increase_aged_brie_quality_twice_as_fast_after_sell_in_becomes_negative()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            var resultItem = Items[0];
            Assert.AreEqual("Aged Brie", resultItem.Name);
            Assert.AreEqual(-1, resultItem.SellIn);
            Assert.AreEqual(7, resultItem.Quality);
        }

        [TestMethod]
        public void Not_increase_aged_brie_quality_past_50()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            var resultItem = Items[0];
            Assert.AreEqual("Aged Brie", resultItem.Name);
            Assert.AreEqual(4, resultItem.SellIn);
            Assert.AreEqual(50, resultItem.Quality);
        }

        //Unique cases: Aged Brie, Backstage passes to a TAFKAL80ETC concert, Sulfuras, Hand of Ragnaros
    }
}
