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
                if (item.Quality < 50)
                {
                    item.Quality++;
                }

                if (item.SellIn < 0 && item.Quality < 50)
                {
                    item.Quality++;
                }

                return;
            }

            if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                if(item.SellIn < 0)
                {
                    item.Quality = 0;
                    return;
                }

                if (item.Quality < 50)
                {
                    item.Quality++;

                    if (item.SellIn < 11 && item.Quality < 50)
                    {
                        item.Quality++;
                    }

                    if (item.SellIn < 6 && item.Quality < 50)
                    {
                        item.Quality++;
                    }
                }
                return;
            }

            if (item.Quality > 0)
            {
                item.Quality--;
            }

            if (item.SellIn < 0 && item.Quality > 0)
            {
                item.Quality--;
            }
        }
    }
}
