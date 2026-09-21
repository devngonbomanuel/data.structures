namespace src.Implementations
{
    public class DictionaryImplementation
    {

        public static void GetAllValues(Dictionary<string, string> dict)
        {
            foreach (var value in dict)
            {
                Console.WriteLine($"Key: {value.Key} | Value: {value.Value}");
            }
        }
        public static void GetValueByKey(Dictionary<string, string> dict, string key)
        {
            if(dict.TryGetValue(key, out var value))
            {
                Console.WriteLine($"{value} exists!");
            }
            else 
            {
                Console.WriteLine($"{value} doesn't exists!");
            }
        }
        public static void AddItem(Dictionary<string, string> dict, string key, string value)
        {

            var status = dict.TryAdd(key, value);
            if (!status)
            {
                Console.WriteLine("This id or item already exists. You can't add repeated values!");
            }
            else
            {
                Console.Write("Item added:");
                Console.WriteLine($"{key} - {value}");
            }
        }
        public static void ContainsKey(Dictionary<string, string> dict, string key)
        {
            if(dict.ContainsKey(key))
            {
                Console.WriteLine($"The key {key} exists");
            }
            else
            {
                Console.WriteLine($"The key {key} doesn't exists");
            }
        }

        public static void ContainsValue(Dictionary<string, string> dict, string value)
        {
            if (dict.ContainsValue(value))
            {
                Console.WriteLine($"The value {value} exists");
            }
            else
            {
                Console.WriteLine($"The value {value} doesn't exists");
            }
        }

        public static void RemoveValueByKey(Dictionary<string, string> dict, string key)
        {
            if(!dict.Remove(key)){
                Console.Write($"The value with the key {key} wasn't removed!");
                Console.WriteLine(" Verify your key.");
            }
            else 
            {
                Console.WriteLine($"Value with the key {key} removed successfully!");
            }
        }



    }
}
