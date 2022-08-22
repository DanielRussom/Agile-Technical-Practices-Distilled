using Agile_Technical_Practices_Distilled.Chapter_9;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Agile_Technical_Practices_Distilled.Tests.Chapter_9
{
    [TestClass]
    public class GildedRoseShould
    {
        [TestMethod]
        [DataRow("foo", 10, 10, 9, 9)]
        [DataRow("foo", 0, 10, -1, 8)]
        [DataRow("Aged Brie", 2, 0, 1, 1)]
        [DataRow("Aged Brie", 0, 5, -1, 7)]
        [DataRow("Aged Brie", 5, 50, 4, 50)]
        [DataRow("Sulfuras, Hand of Ragnaros", 5, 10, 5, 10)]
        [DataRow("Backstage passes to a TAFKAL80ETC concert", 0, 25, -1, 0)]
        [DataRow("Backstage passes to a TAFKAL80ETC concert", 15, 25, 14, 26)]
        [DataRow("Backstage passes to a TAFKAL80ETC concert", 10, 25, 9, 27)]
        [DataRow("Backstage passes to a TAFKAL80ETC concert", 5, 48, 4, 50)]
        [DataRow("Backstage passes to a TAFKAL80ETC concert", 5, 25, 4, 28)]
        [DataRow("Conjured Mana Cake", 5, 25, 4, 23)]
        [DataRow("Conjured Mana Cake", 0, 25, -1, 21)]
        public void Update_sellIn_and_quality_as_expected
            (string name, int initialSellIn, int initialQuality, int expectedSellIn, int expectedQuality)
        {
            var testItems = new List<Item> { new Item { Name = name, SellIn = initialSellIn, Quality = initialQuality } };
            var UnderTest = new GildedRose(testItems);

            UnderTest.UpdateQuality();
            
            var resultItem = testItems[0];
            Assert.AreEqual(name, resultItem.Name);
            Assert.AreEqual(expectedSellIn, resultItem.SellIn);
            Assert.AreEqual(expectedQuality, resultItem.Quality);
        }

        [TestMethod]
        public void Process_multiple_items()
        {
            var testItems = new List<Item> { 
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 25 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 10 }
            };

            var UnderTest = new GildedRose(testItems);

            UnderTest.UpdateQuality();

            var passItem = testItems[0];
            var sulfurasItem = testItems[1];
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", passItem.Name);
            Assert.AreEqual(14, passItem.SellIn);
            Assert.AreEqual(26, passItem.Quality);

            Assert.AreEqual("Sulfuras, Hand of Ragnaros", sulfurasItem.Name);
            Assert.AreEqual(5, sulfurasItem.SellIn);
            Assert.AreEqual(10, sulfurasItem.Quality);
        }

        [TestMethod]
        public void Not_allow_quality_to_be_above_50()
        {
            var testItems = new List<Item> {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 60 },
                new Item { Name = "Aged Brie", SellIn = 20, Quality = 60 },
                new Item { Name = "foo", SellIn = 20, Quality = 60 }
            };

            var UnderTest = new GildedRose(testItems);

            UnderTest.UpdateQuality();

            var passItem = testItems[0];
            var brieItem = testItems[1];
            var fooItem = testItems[2];
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", passItem.Name);
            Assert.AreEqual(19, passItem.SellIn);
            Assert.AreEqual(50, passItem.Quality);

            Assert.AreEqual("Aged Brie", brieItem.Name);
            Assert.AreEqual(19, brieItem.SellIn);
            Assert.AreEqual(50, brieItem.Quality);

            Assert.AreEqual("foo", fooItem.Name);
            Assert.AreEqual(19, fooItem.SellIn);
            Assert.AreEqual(50, fooItem.Quality);
        }
    }
}
