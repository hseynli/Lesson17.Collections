using System.Collections;

public class UserCollection<T> : IEnumerable<T>, IEnumerator<T>
{
    readonly T[] elements = new T[4];

    public T this[int index]
    {
        get { return elements[index]; }
        set { elements[index] = value; }
    }

    int position = -1;

    // IEnumerator<T> interfeysinin realizasiyası:
    bool IEnumerator.MoveNext()
    {
        if (position < elements.Length - 1)
        {
            position++;
            return true;
        }
        return false;
    }

    void IEnumerator.Reset()
    {
        position = -1;
    }

    object IEnumerator.Current
    {
        get { return elements[position]; }
    }

    T IEnumerator<T>.Current
    {
        get { return elements[position]; }
    }

    // IEnumerable<T> interfeysinin realizasiyası:
    IEnumerator IEnumerable.GetEnumerator()
    {
        return this;
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        return this;
    }

    // IDisposable interfeysinin realizasiyası:
    void IDisposable.Dispose()
    {
        ((IEnumerator)this).Reset();
    }
}