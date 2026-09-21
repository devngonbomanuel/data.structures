namespace src.Implementations
{
    public class StackImplementation
    {
        public static void AddItem(Stack<string> stack, string item)
        {
            stack.Push(item);
            Console.WriteLine("Item added!");
        }
        public static void GetLastItem(Stack<string> stack)
        {
            if(!stack.TryPeek(out var result))
            {
                Console.WriteLine("No items too see!");
            }
            else
            {
                Console.WriteLine($"Last item: {result}");
            }
        }

        public static void RemoveLastItem(Stack<string> stack)
        {
            if(!stack.TryPop(out var result))
            {
                Console.WriteLine($"No items to remove!");
            }
            else
            {
                Console.WriteLine($"Removed: {result}");
            }
        }
        public static void CountItems(Stack<string> stack)
        {
           int size =  stack.Count();
            if (size > 0)
            {
                Console.WriteLine($"Has {size} item(s).");
            }
            else
            {
                Console.WriteLine("Hasn't items.");
            }
        }


        public static void Clear(Stack<string> stack)
        {
            stack.Clear();
            Console.WriteLine("All items removed!");
        }

        public static void CountainsItem(Stack<string> stack, string item)
        { 
            if (stack.Contains(item))
            {
                Console.WriteLine($"{item} exists!");
            }
            else
            {
                Console.WriteLine($"Doesn't exists!");
            }
        }
    }
}
