using System.Collections;

public class UserCollection<T>
{
    readonly T[] elements = new T[4];

    public T this[int index]
    {
        get { return elements[index]; }
        set { elements[index] = value; }
    }

    int position = -1;

    // Reset().
    public void Reset()
    {
        position = -1;
    }

    // yield operatorondan istifadə edən GetEnumerator() metodu yaradırıq.
    public IEnumerator GetEnumerator()
    {
        // ---------- 1-й вариант. ----------

        while (true)
        {
            if (position < elements.Length - 1)
            {
                position++;
                yield return elements[position];
            }
            else
            {
                Reset();
                yield break;
            }
        }

        // ---------- 2-ci variant. ----------

        //foreach (var element in elements)
        //{
        //    yield return element;
        //}

        // ---------- 3-cü variant. ----------

        //return elements.GetEnumerator();
    }
}