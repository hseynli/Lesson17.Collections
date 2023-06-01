string[] names = new string[] { "Farid", "Hesen" };

List<string> namesOfList = new List<string> { "Farid", "Hesen" };

Show(names);
Console.WriteLine(new string('-', 80));
Show(namesOfList);

void Show(IEnumerable<string> names)
{
    foreach (var name in names)
    {
        Console.WriteLine(name);
    }
}