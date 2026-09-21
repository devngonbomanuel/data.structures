namespace src.Implementations
{
    public class QueueImplementation
    {
        public static void AddItem(Queue<string> queue, string item)
        {
            queue.Enqueue(item);
        }

        public static void GetFirstItem(Queue<string> queue)
        {
            if (queue.TryPeek(out var result))
            {
                Console.WriteLine($"Item: {result}");
            }
            else
            {
                Console.WriteLine($"No items to see!");
            }
        }
        public static void RemoveFirstItem(Queue<string> queue)
        {
            var geItem = queue.Dequeue();
            Console.WriteLine($"Removed: {geItem}");
        }
        public static void ContainsItem(Queue<string> queue, string item)
        {
            if (queue.Contains(item))
            {
                Console.WriteLine($"{item} exists!");
            }
            else
            {
                Console.WriteLine($"{item} doesn't exists!");
            }

        }
        
        public static void DeleteAllItems(Queue<string> queue, string item)
        {
            queue.Clear();
            Console.WriteLine("All the items deleted successfully!");
        }


    }
}
