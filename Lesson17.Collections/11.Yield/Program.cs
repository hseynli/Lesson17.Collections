using System.Collections;

foreach (string element in UserCollection.Power())
    Console.WriteLine(element);

// Delay. 
Console.ReadKey();

class UserCollection
{
    public static IEnumerable Power()
    {
        while (true)
            yield return "Hello world!";
    }
}