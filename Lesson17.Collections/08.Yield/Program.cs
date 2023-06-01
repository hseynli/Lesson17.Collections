using System.Collections;

foreach (string element in UserCollection.Power())
    Console.Write(element);

// Delay. 
Console.ReadKey();

class UserCollection
{
    public static IEnumerable Power()
    {
        yield break;
    }
}