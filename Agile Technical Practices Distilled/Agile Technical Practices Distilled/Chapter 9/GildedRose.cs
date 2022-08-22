namespace Agile_Technical_Practices_Distilled.Chapter_9
{
    public class GildedRose
    {
        IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach(var item in Items)
            {
                ProcessItem(item);
            }
        }

        private void ProcessItem(Item item)
        {
            if (item.Name == "Sulfuras, Hand of Ragnaros")
            {
                return;
            }

            item.SellIn--;

            if (item.Name == "Aged Brie")
            {
                ProcessBrie(item);
                return;
            }

            if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                ProcessBackstagePasses(item);
                return;
            }

            DegradeQuality(item);
        }

        private void ProcessBrie(Item item)
        {
            IncrementQuality(item);

            if (SellInIsNegative(item))
            {
                IncrementQuality(item);
            }

            if (QualityIsAboveUpperLimit(item))
            {
                item.Quality = 50;
            }
        }

        private static bool SellInIsNegative(Item item)
        {
            return item.SellIn < 0;
        }

        private static int IncrementQuality(Item item)
        {
            return item.Quality++;
        }

        private static bool QualityIsAboveUpperLimit(Item item)
        {
            return item.Quality > 50;
        }

        private static bool QualityIsBelowUpperLimit(Item item)
        {
            return item.Quality < 50;
        }

        private void ProcessBackstagePasses(Item item)
        {
            if (SellInIsNegative(item))
            {
                item.Quality = 0;
                return;
            }



            if (QualityIsAboveUpperLimit(item))
            {
                item.Quality = 50;
            }

            if (!QualityIsBelowUpperLimit(item))
            {
                return;
            }

            IncrementQuality(item);

            if (item.SellIn < 11 && QualityIsBelowUpperLimit(item))
            {
                IncrementQuality(item);
            }

            if (item.SellIn < 6 && QualityIsBelowUpperLimit(item))
            {
                IncrementQuality(item);
            }
        }

        private void DegradeQuality(Item item)
        {
            if (QualityIsAboveUpperLimit(item))
            {
                item.Quality = 50;
                return;
            }

            if (item.Quality > 0)
            {
                DecrementQuality(item);
            }

            if (SellInIsNegative(item) && item.Quality > 0)
            {
                DecrementQuality(item);
            }
        }

        private static int DecrementQuality(Item item)
        {
            return item.Quality--;
        }
    }
}
