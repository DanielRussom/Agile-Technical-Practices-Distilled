using Agile_Technical_Practices_Distilled.Chapter_9;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_9
{
    [TestClass]
    public class GildedRoseShould
    {
        [TestMethod]
        public void Lower_sell_in_value_and_quality_of_default_object()
        {
            var testItems = new List<Item> { new Item { Name = "foo", SellIn = 10, Quality = 10 } };
            var UnderTest = new GildedRose(testItems);

            UnderTest.UpdateQuality();
            
            var resultItem = testItems[0];
            Assert.AreEqual("foo", resultItem.Name);
            Assert.AreEqual(9, resultItem.SellIn);
            Assert.AreEqual(9, resultItem.Quality);
        }

        [TestMethod]
        public void Lower_quality_by_two_for_default_object_with_negative_sell_in()
        {
            var testItems = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 10 } };
            var UnderTest = new GildedRose(testItems);

            UnderTest.UpdateQuality();

            var resultItem = testItems[0];
            Assert.AreEqual(-1, resultItem.SellIn);
            Assert.AreEqual(8, resultItem.Quality);
        }

        [TestMethod]
        public void Increase_aged_brie_quality()
        {
            var testItems = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 } };
            var UnderTest = new GildedRose(testItems);

            UnderTest.UpdateQuality();

            var resultItem = testItems[0];
            Assert.AreEqual("Aged Brie", resultItem.Name);
            Assert.AreEqual(1, resultItem.SellIn);
            Assert.AreEqual(1, resultItem.Quality);
        }

        [TestMethod]
        public void Increase_aged_brie_quality_twice_as_fast_after_sell_in_becomes_negative()
        {
            var testItems = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 5 } };
            var UnderTest = new GildedRose(testItems);

            UnderTest.UpdateQuality();

            var resultItem = testItems[0];
            Assert.AreEqual("Aged Brie", resultItem.Name);
            Assert.AreEqual(-1, resultItem.SellIn);
            Assert.AreEqual(7, resultItem.Quality);
        }

        [TestMethod]
        public void Not_increase_aged_brie_quality_past_50()
        {
            var testItems = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 50 } };
            var UnderTest = new GildedRose(testItems);

            UnderTest.UpdateQuality();

            var resultItem = testItems[0];
            Assert.AreEqual("Aged Brie", resultItem.Name);
            Assert.AreEqual(4, resultItem.SellIn);
            Assert.AreEqual(50, resultItem.Quality);
        }

        [TestMethod]
        public void Not_decrease_values_of_sulfuras()
        {
            var testItems = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 10 } };
            var UnderTest = new GildedRose(testItems);

            UnderTest.UpdateQuality();

            var resultItem = testItems[0];
            Assert.AreEqual("Sulfuras, Hand of Ragnaros", resultItem.Name);
            Assert.AreEqual(5, resultItem.SellIn);
            Assert.AreEqual(10, resultItem.Quality);
        }

        [TestMethod]
        public void Set_value_of_tickets_with_negative_sell_to_0()
        {
            var testItems = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 25 } };
            var UnderTest = new GildedRose(testItems);

            UnderTest.UpdateQuality();

            var resultItem = testItems[0];
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", resultItem.Name);
            Assert.AreEqual(-1, resultItem.SellIn);
            Assert.AreEqual(0, resultItem.Quality);
        }

        [TestMethod]
        public void Increase_value_of_tickets_by_one()
        {
            var testItems = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 25 } };
            var UnderTest = new GildedRose(testItems);

            UnderTest.UpdateQuality();

            var resultItem = testItems[0];
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", resultItem.Name);
            Assert.AreEqual(14, resultItem.SellIn);
            Assert.AreEqual(26, resultItem.Quality);
        }

        [TestMethod]
        public void Increase_value_of_tickets_by_two()
        {
            var testItems = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 25 } };
            var UnderTest = new GildedRose(testItems);

            UnderTest.UpdateQuality();

            var resultItem = testItems[0];
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", resultItem.Name);
            Assert.AreEqual(9, resultItem.SellIn);
            Assert.AreEqual(27, resultItem.Quality);
        }

        [TestMethod]
        public void Increase_value_of_tickets_by_two_due_to_50_limit()
        {
            var testItems = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 48 } };
            var UnderTest = new GildedRose(testItems);

            UnderTest.UpdateQuality();

            var resultItem = testItems[0];
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", resultItem.Name);
            Assert.AreEqual(4, resultItem.SellIn);
            Assert.AreEqual(50, resultItem.Quality);
        }

        [TestMethod]
        public void Increase_value_of_tickets_by_three()
        {
            var testItems = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 25 } };
            var UnderTest = new GildedRose(testItems);

            UnderTest.UpdateQuality();

            var resultItem = testItems[0];
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", resultItem.Name);
            Assert.AreEqual(4, resultItem.SellIn);
            Assert.AreEqual(28, resultItem.Quality);
        }
    }
}
