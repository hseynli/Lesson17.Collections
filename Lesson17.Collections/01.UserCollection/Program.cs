using System.Collections;

UserCollection myCollection = new UserCollection();

// IEnumerable və IEnumerator interfeyslərini realizasiya edən kolleksiyalar foreach dövrünə salına bilər. 
foreach (Element element in myCollection)
{
    Console.WriteLine("Name: {0}  Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
}

Console.Write(new string('-', 29) + "\n");

//myCollection.Reset(); // Şərhdən çıxarmaq

foreach (Element element in myCollection)
{
    Console.WriteLine("Name: {0}  Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
}

Console.Write(new string('-', 29) + "\n");


UserCollection myElementsCollection = new UserCollection();

// Upcast
IEnumerable enumerable = myElementsCollection as IEnumerable;

// GetEnumerator() metodu vasitəsilə IEnumerator obyektini alırıq.            
IEnumerator enumerator = enumerable.GetEnumerator();


while (enumerator.MoveNext())
{
    Element element = enumerator.Current as Element;

    Console.WriteLine("Name: {0}  Field1: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
}

enumerator.Reset();

// Delay.
Console.ReadKey();