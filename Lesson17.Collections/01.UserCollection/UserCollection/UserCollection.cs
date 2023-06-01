using System.Collections;

public class UserCollection : IEnumerable, IEnumerator
{
    public Element[] elementsArray = null;

    public UserCollection()
    {
        elementsArray = new Element[4];
        elementsArray[0] = new Element("A", 1, 10);
        elementsArray[1] = new Element("B", 2, 20);
        elementsArray[2] = new Element("C", 3, 30);
        elementsArray[3] = new Element("D", 4, 40);
    }

    // Cari pozisiya.
    int position = -1;

    // Növbəti element.
    public bool MoveNext()
    {
        if (position < elementsArray.Length - 1)
        {
            position++;
            return true;
        }
        else
        {
            return false;
        }
    }

    // Cari pozisiyanı sıfırlamaq.
    public void Reset()
    {
        position = -1;
    }

    // Cari element. 
    public object Current
    {
        get { return elementsArray[position]; }
    }

    // -----------------------------------------------------------------------------------------------------------------
    // İterasiya obyekti.

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this as IEnumerator;
    }
}