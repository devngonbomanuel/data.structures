using src.models.Product;

namespace src.Implementations
{
    public class ListImplementation
    {
        public static void GetItems(List<string> list)
        {
            Console.Write($"Itens: ");
            foreach (var item in list)
            {
                Console.Write($"{item} | ");
            }
        }

        public static void  AddItems(List<string> list, string item)
        {
            var successMessage = "Item added!";

            list.Add(item);

            Console.WriteLine(successMessage);
        }


        public static void GetSize(List<string> list)
        {
            Console.WriteLine($"List size: {list.Count} items");
        }


        public static void GetCapacity(List<string> list)
        {
            Console.WriteLine($"List capacity: {list.Capacity}");
        }



        public static void ContainsItem(List<string> list, string item)
        {
            Console.WriteLine($"{list.Contains(item)}");
        }


        public static void ClearList(List<string> list)
        {
            list.Clear();
        }


        public static void RemoveItem(List<string> list, string item)
        {
            list.Remove(item);
        }


        public static void RemoveItemByParameter(List<string> list, char parameter)
        {
            list.RemoveAll(x => x.StartsWith(parameter));
        }


        public static void RemoveByIndex(List<string> list, int position)
        {
            list.RemoveAt(position);
        }


        public static void GetProductByParameter(List<Product> list, int  id)
        {
            var item = list.Find(x => x.Id == id);
            Console.Write($"Id: {item.Id} | Nome: {item.ProductName}");
        }


        public static void CombineListWithSpread(List<int> firstList, List<int> secondList)
        {
            List<int> combinedList = [.. firstList, .. secondList];
            foreach (var item in combinedList)
            {
                Console.WriteLine($"Itens: {item}");
            }
        }
    }
}
