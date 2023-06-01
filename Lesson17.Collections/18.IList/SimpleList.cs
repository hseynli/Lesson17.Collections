using System.Collections;

class SimpleList : IList //, ICollection, IEnumerable
{
    private readonly object[] contents = new object[8];
    private int count;

    public SimpleList()
    {
        count = 0;
    }

    #region IList Members

    // Yeni element əlavə edir.
    public int Add(object value)
    {
        if (count < contents.Length)
        {
            contents[count] = value;
            count++;

            return (count - 1);
        }
        return -1;
    }

    // Siyahıdan bütün elementləri silir.
    public void Clear()
    {
        count = 0;
    }

    // Qəbul edilən arqumentin siyadı olub-olmamasını yoxlayır.
    public bool Contains(object value)
    {
        for (int i = 0; i < Count; i++)
        {
            if (contents[i] == value)
                return true;
        }
        return false;
    }

    // Arqumentdə verilən elementin siyahıda hansı pozisiyada olmasını təyin edir.
    public int IndexOf(object value)
    {
        for (int i = 0; i < Count; i++)
            if (contents[i] == value)
                return i;
        return -1;
    }

    // Verilən indeksə yeni element əlavə edir.
    public void Insert(int index, object value)
    {
        if ((count + 1 <= contents.Length) && (index < Count) && (index >= 0))
        {
            count++;

            for (int i = Count - 1; i > index; i--)
            {
                contents[i] = contents[i - 1];
            }
            contents[index] = value;
        }
    }

    // Siyahının fiks (konkret) ölçüdən ibrarət olub-olmadığını təyin edir.
    public bool IsFixedSize
    {
        get { return true; }
    }

    // Siyanın ancaq axunma üçün (readonly) olub olmadığını müəyyən edir.
    public bool IsReadOnly
    {
        get { return false; }
    }

    // Birini tapılan elementi siyadıdan silir..
    public void Remove(object value)
    {
        RemoveAt(IndexOf(value));
    }

    // Verilən indeksdə olan elementi siyahıdan silir.
    public void RemoveAt(int index)
    {
        if ((index >= 0) && (index < Count))
        {
            for (int i = index; i < Count - 1; i++)
                contents[i] = contents[i + 1];

            count--;
        }
    }

    public object this[int index]
    {
        get
        {
            return contents[index];
        }
        set
        {
            contents[index] = value;
        }
    }

    #endregion

    #region ICollection Members

    // Siyahını Array-a kopyalayır.
    public void CopyTo(Array array, int index)
    {
        int j = index;
        for (int i = 0; i < Count; i++)
        {
            array.SetValue(contents[i], j);
            j++;
        }
    }

    // Siyadıdakı element sayını qaytarır.
    public int Count
    {
        get { return count; }
    }

    // ICollection kolleksiyasında olan elementlərin sinxron (Thread-safe) olub-olmamasını yoxlayır.
    public bool IsSynchronized
    {
        get { return false; }
    }

    // ICollection kolleksiyasına sinxron (Thread-safe) müraciət etmək üçün object geri qaytarır.
    public object SyncRoot
    {
        get { return null; }
    }

    #endregion

    #region IEnumerable Members

    // İterasiya obyektini geri qaytarır.
    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < Count; i++)
        {
            yield return contents[i];
        }
    }

    #endregion

    public void PrintContents()
    {
        Console.WriteLine("Siyahının ölçüsü {0}, hal-hazırda {1} elementdən ibratədir", contents.Length, count);
        Console.Write("Siyahıdakı elementlər:");

        for (int i = 0; i < Count; i++)
            Console.Write(" {0}", contents[i]);

        Console.WriteLine("\n" + new string('-', 55));
    }
}