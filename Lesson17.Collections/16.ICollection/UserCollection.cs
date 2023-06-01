using System.Collections;

class UserCollection : ICollection
{
    readonly object syncRoot = new object();

    readonly object[] elements = { 1, 2, 3, 4 };

    // ICollection-ın elementlərini müəyyən indeksdən başlayaraq Array-a kopyalayır.
    public void CopyTo(Array array, int userArrayIndex)
    {
        var arr = array as object[];

        if (arr == null)
        {
            Console.WriteLine("Expecting array to be object[]");
            return;
        }

        for (int i = 0; i < array.Length; i++)
        {
            arr[userArrayIndex++] = elements[i];
        }
    }

    // ICollection kolleksiyasında olan elementlərin sayını geri qaytarır.
    public int Count
    {
        get { return elements.Length; }
    }

    // ICollection kolleksiyasında olan elementlərin sinxron (Thread-safe) olub-olmamasını yoxlayır.
    public bool IsSynchronized
    {
        get { return true; }
    }

    // ICollection kolleksiyasına sinxron (Thread-safe) müraciət etmək üçün object geri qaytarır.
    public object SyncRoot
    {
        get { return syncRoot; }
    }

    // İterasiya obyektini geri qaytarır.
    public IEnumerator GetEnumerator()
    {
        return elements.GetEnumerator();
    }
}