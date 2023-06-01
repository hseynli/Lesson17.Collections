Console.OutputEncoding = System.Text.Encoding.UTF8;

var list = new SimpleList { "one", "two", "three", "four", "five", "six", "seven", "eight" };

list.PrintContents();

Console.WriteLine("Siyahıdan elementlərin silinməsi:");
list.Remove("six");
list.Remove("eight");
list.PrintContents();

Console.WriteLine("Siyahıya yeni elementlərin əlavə edilməsi:");
list.Add("nine");
list.PrintContents();

Console.WriteLine("Elementi siyahının ortasına əlavə edilməsi:");
list.Insert(4, "number");
list.PrintContents();

Console.WriteLine("Konkret elementlərin siyahıda olub-olmamasının yoxlanılması:");
Console.WriteLine("Siyahıda bu söz var: \"three\": {0}", list.Contains("three"));
Console.WriteLine("Siyahıda bu söz var: \"ten\"  : {0}", list.Contains("ten"));

Console.WriteLine("\nSiyahıdakı bütün elementlərin əks olunması:");
foreach (string s in list)
{
    Console.WriteLine(s);
}
// Delay.
Console.ReadKey();