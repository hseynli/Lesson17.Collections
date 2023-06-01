using System.Collections;

foreach (var item in UserCollection.Power(5))
{
    Console.WriteLine(item);
}

class UserCollection
{
    public static IEnumerable Power(int count)
    {
        for (int i = 0; i < count; i++)
            yield return i;        
    }
}