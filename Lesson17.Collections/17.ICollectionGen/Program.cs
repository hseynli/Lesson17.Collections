var collection = new UserCollection<int> { 1, 2, 3 };

foreach (var item in collection)
{
    Console.WriteLine(item);
}

Console.WriteLine(collection.Contains(2));