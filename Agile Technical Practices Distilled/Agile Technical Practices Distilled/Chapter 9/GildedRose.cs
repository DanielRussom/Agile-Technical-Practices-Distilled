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

            if (QualityHasHitUpperLimit(item))
            {
                item.Quality = 50;
            }
        }

        private static int IncrementQuality(Item item)
        {
            return item.Quality++;
        }

        private static bool SellInIsNegative(Item item)
        {
            return item.SellIn < 0;
        }

        private static bool QualityHasHitUpperLimit(Item item)
        {
            return item.Quality >= 50;
        }

        private void ProcessBackstagePasses(Item item)
        {
            if (SellInIsNegative(item))
            {
                item.Quality = 0;
                return;
            }

            IncrementQuality(item);

            if (item.SellIn < 11)
            {
                IncrementQuality(item);
            }

            if (item.SellIn < 6)
            {
                IncrementQuality(item);
            }

            if (QualityHasHitUpperLimit(item))
            {
                item.Quality = 50;
            }
        }

        private void DegradeQuality(Item item)
        {
            if (QualityHasHitUpperLimit(item))
            {
                item.Quality = 50;
                return;
            }

            DecrementQuality(item);

            if (SellInIsNegative(item))
            {
                DecrementQuality(item);
            }

            if (QualityIsNegative(item))
            {
                item.Quality = 0;
            }
        }

        private static int DecrementQuality(Item item)
        {
            return item.Quality--;
        }

        private static bool QualityIsNegative(Item item)
        {
            return item.Quality < 0;
        }
    }
}
