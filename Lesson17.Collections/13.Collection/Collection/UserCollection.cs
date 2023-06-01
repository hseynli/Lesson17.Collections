public class UserCollection
{
    readonly Element[] elements = new Element[4];

    public Element this[int index]
    {
        get { return elements[index]; }
        set { elements[index] = value; }
    }

    int position = -1;

    // IEnumerator interfeysinin realizasiyası:

    public bool MoveNext()
    {
        if (position < elements.Length - 1)
        {
            position++;
            return true;
        }
        // Mexaniki olaraq özümüz Reset metodunu çağırırıq.
        Reset();
        return false;
    }

    public void Reset()
    {
        position = -1;
    }

    public object Current
    {
        get { return elements[position]; }
    }

    // IEnumerable interfeyinin realizasiyası:

    public UserCollection GetEnumerator()
    {
        return this;
    }
}