using System.Collections;

foreach (var element in UserCollection.Power())
    Console.WriteLine(element);

// Delay. 
Console.ReadKey();

class UserCollection
{
    public static IEnumerable Power()
    {
        for (int i = 0; i < 100; i++)
        {
            yield return i;

            if(i == 10)
                yield break;
        }        
    }
}