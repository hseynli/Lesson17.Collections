using System.Collections;

Week week = new Week();

foreach (var day in week)
{
    Console.WriteLine(day);
}

class Week : IEnumerable
{
    readonly string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
                         "Friday", "Saturday", "Sunday" };
    public IEnumerator GetEnumerator() => days.GetEnumerator();
}