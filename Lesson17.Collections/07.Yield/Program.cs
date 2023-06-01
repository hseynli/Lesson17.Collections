using System.Collections;

foreach (string element in UserCollection.Power())
    Console.WriteLine(element);

Console.WriteLine(new string('-', 12));

IEnumerable enumerable = UserCollection.Power();

IEnumerator enumerator = enumerable.GetEnumerator();

while (enumerator.MoveNext()) // Kursu bir addım qabağa salırıq.
{
    String element = enumerator.Current as String;

    Console.WriteLine(element);
}

class UserCollection
{
    public static IEnumerable Power()
    {
        yield return "Hello world!";
    }
}