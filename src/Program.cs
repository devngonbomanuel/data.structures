using src.Implementations;
using src.models.Product;

//--CONTENT: Arrays practice--

//string[] daysOfWeek = [
//"Sunday",
//"Monday",
//"Tuesday",
//"Wednesday",
//"Thursday",
//"Friday",
//"Saturday",
//];

//int[] points = [12, 11, 8, 1, 0, 1];
//int[] points2 = new int[6];

//ArrayImplementation.GetArrayValues(daysOfWeek);
//ArrayImplementation.GetArraySize(daysOfWeek);
//ArrayImplementation.ArraySort(points);
//ArrayImplementation.ArraysCopy(points, points2);
//ArrayImplementation.ArrayReverse(points);
//ArrayImplementation.ArrayFind(points, 6);
//ArrayImplementation.ArrayBinarySearch(points,4);


//--CONTENT: Lists practice--
//List<string> products = ["Keyboard", "Mouse", "Monitor", "CPU"];

//List<Product> product = new()
//{
//    new Product { Id = 1, ProductName = "Keyboard"},
//    new Product { Id = 2, ProductName = "Mouse"},
//    new Product { Id = 3, ProductName = "Monitor"}
//};


//List<int> firstPoints = [12, 11, 9];

//List<int> secondPoints = [12, 11, 9];


//ListImplementation.CombineListWithSpread(firstPoints, secondPoints);



//ListImplementation.AddItems(products, "RAM");

//ListImplementation.GetSize(products);

//ListImplementation.GetCapacity(products);

//ListImplementation.ContainsItem(products, "Keyboard");

//ListImplementation.ClearList(products);

//ListImplementation.RemoveItem(products, "mouse");

//ListImplementation.RemoveItemByParameter(products, 'M');

//ListImplementation.RemoveByIndex(products, 2);


//ListImplementation.GetItems(products);

//ListImplementation.GetProductByParameter(product, 3);


//--CONTENT: Queues practice--

Queue<string> emails = new Queue<string>();


QueueImplementation.AddItem(emails, "joao@mail.com");
QueueImplementation.AddItem(emails, "mary@mail.com");


QueueImplementation.GetFirstItem(emails);

//QueueImplementation.RemoveFirstItem(emails);

//QueueImplementation.GetFirstItem(emails);

//QueueImplementation.ContainsItem(emails, "mary@mail.com");


//--CONTENT: Stacks practice--

//Stack<string> historicoNavegacao = new Stack<string>();

//StackImplementation.AddItem(historicoNavegacao, "https//site.com/menu");
//StackImplementation.AddItem(historicoNavegacao, "https//site.com/contatos");
//StackImplementation.AddItem(historicoNavegacao, "https//site.com/sobre");

//StackImplementation.GetLastItem(historicoNavegacao);

//StackImplementation.RemoveLastItem(historicoNavegacao);
//StackImplementation.RemoveLastItem(historicoNavegacao);
//StackImplementation.CountItems(historicoNavegacao);
//StackImplementation.Clear(historicoNavegacao);

//StackImplementation.CountainsItem(historicoNavegacao, "https//site.com/sobre");


//--CONTENT: Dictionaries practice--
//Dictionary<string, string> query=new Dictionary<string, string>();

//DictionaryImplementation.AddItem(query, "a321", "joao@mail.com");
//DictionaryImplementation.AddItem(query, "a322", "kizua@mail.com");
//DictionaryImplementation.AddItem(query, "a323", "azura@mail.com");
//DictionaryImplementation.ContainsKey(query, "a322");
//DictionaryImplementation.ContainsValue(query, "azure@mail.com");
//DictionaryImplementation.RemoveValueByKey(query, "a322");
//DictionaryImplementation.GetAllValues(query);
//DictionaryImplementation.GetValueByKey(query, "a322");



//--CONTENT: Hashsets practice--
//HashSet<string> idStorage = new HashSet<string>();
//HashSetImplementation.AddElement(idStorage, "e432101");
//HashSetImplementation.AddElement(idStorage, "e781111");
//HashSetImplementation.AddElement(idStorage, "e652189");

//HashSet<string> idAdded = new HashSet<string>();
//HashSetImplementation.AddElement(idAdded, "a231xv113");
//HashSetImplementation.AddElement(idAdded, "ab9881290");
//HashSetImplementation.AddElement(idAdded, "az9118323");


//HashSetImplementation.GetAllElement(idAdded);
//HashSetImplementation.ContainsElement(idStorage, "e652189");



//--CONTENT: IEnumerables practice--
//IEnumerable<int> collection;

//collection = IEnumerableImplementation.Iterator(20);

//IEnumerableImplementation.ShowValues(collection);