namespace src.Implementations
{
    public class HashSetImplementation
    {
        public static void GetAllElement(HashSet<string> hashSet)
        {
            Console.WriteLine($"Elements: ");
            foreach (var value in hashSet)
            {
                Console.WriteLine(value);
            }
        }
        public static void AddElement(HashSet<string> hashSet, string element)
        {
            var status = hashSet.Add(element);
            //if(status)
            //{
            //    Console.WriteLine("Element added!");
            //}
            //else
            //{
            //    Console.WriteLine($"{element} already exists!");
            //}
            //Console.WriteLine($"Item added: {element}");
        }

        public static void ContainsElement(HashSet<string> hashSet, string element)
        {
            var result = hashSet.Contains(element);

            if (result)
            {
                Console.WriteLine($"{element} exists.");
            }
            else
            {
                Console.WriteLine($"{element} doesn't exists!");
            }
        }

    }
}
