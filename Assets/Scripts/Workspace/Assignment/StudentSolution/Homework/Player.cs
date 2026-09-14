namespace Assignment.StudentSolution
{
    public class Player : Entity
    {
        public int score;
        private Item[] items = new Item[0];

        public void CollectItem(Item item)
        {
            if (item == null)
            {
                return;
            }

            Item[] newItems = new Item[items.Length + 1];

            for (int i = 0; i < items.Length; i++)
            {
                newItems[i] = items[i];
            }

            newItems[newItems.Length - 1] = item;
            items = newItems;
        }

        protected void LevelUp()
        {
            score += 100;
        }
    }
}