namespace src.Implementations
{
    public class ArrayImplementation
    {
        public static void GetArrayValues(string[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine($"Days: {item}");
            }

        }
        public static void GetArraySize(string[] arr)
        {
            Console.WriteLine($"\nSize: {arr.Length}");
        }

        public static void ArraySort(int[] intArr)
        {
            Array.Sort(intArr);

            foreach (var value in intArr)
            {
                Console.WriteLine($"Value: {value}");
            }
        }
        public static void ArraysCopy(int[] intArr, int[] intArr2)
        {
            int size = intArr.Length / 2;
            Array.Copy(intArr, intArr2, size);

            foreach (var value in intArr)
            {
                Console.WriteLine($"Source: {value}");
            }

            foreach (var value in intArr2)
            {
                Console.WriteLine($"Destination: {value}");
            }
        }

        public static void ArrayReverse(int[] intArr)
        {
            Array.Reverse(intArr);

            foreach (var value in intArr)
            {
                Console.WriteLine($"Value: {value}");
            }
        }

        public static void ArrayFind(int[] intArr, int item)
        {
            int result = Array.Find(intArr, x => x.Equals(item));

            if (result > 0)
            {
                Console.Write($"Result: {result}");
            }
            else
            {
                Console.WriteLine($"Doesn't exists: {item}");
            }
        }
        public static void ArrayBinarySearch(int[] intArr, int item)
        {
            Array.Sort(intArr);
            int result = Array.BinarySearch(intArr, item);
            if(result > 0)
            {
                Console.Write($"Founded in position {result}");
            }
            else
            {
                Console.Write($"Not found");
            }
                
        }
    }
}
