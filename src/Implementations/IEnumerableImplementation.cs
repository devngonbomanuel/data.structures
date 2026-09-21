namespace src.Implementations
{
    public class IEnumerableImplementation
    {
        public static IEnumerable<int> Iterator(int limit) 
        {
            for (int i = 0; i <= limit; i++)
            {
                if (i % 2 == 0) yield return i;
            }


        }

        public static void ShowValues(IEnumerable<int> enumerable)
        {
            foreach (var num in enumerable)
            {
                Console.WriteLine(num);
            }
        }
    }
}
