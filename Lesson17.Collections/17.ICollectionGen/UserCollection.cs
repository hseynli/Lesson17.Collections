using System.Collections;

class UserCollection<T> : ICollection<T>
{
    T[] elements = new T[0];

    // Yeni element əlavə edirik.
    public void Add(T item)
    {
        var newArray = new T[elements.Length + 1]; // Yeni massivin yaradılması (köhnədən bir elemenet daha çox).
        elements.CopyTo(newArray, 0);              // Köhnə massivin yeni massivə köçürülməsi.
        newArray[newArray.Length - 1] = item;      // Yeni dəyərin massivin sonuna əlavə edilməsi.
        elements = newArray;                       // Könə massivin yenisi ilə əvəz edilməsi.
    }

    // Kolleksiyadan bütün elementləri silir.
    public void Clear()
    {
        elements = new T[0];
    }

    // Daxil olan elementin kolleksiyada olub-olmamasını yoxlayır.
    public bool Contains(T item)
    {
        foreach (var element in elements)
        {
            if (element.Equals(item))
                return true;
        }

        return false;
    }

    // Elementləri koylayır.
    public void CopyTo(T[] array, int arrayIndex)
    {
        elements.CopyTo(array, arrayIndex);
    }

    // Kolleksiyadakı element sayını geri qaytarır.
    public int Count
    {
        get { return elements.Length; }
    }

    // Kolleksiyanın ancaq oxuna bilmə üçün olub-olmadığını geriyə qaytarır.
    public bool IsReadOnly
    {
        get { return false; }
    }

    // Daxil olan elementi kolleksiyadan silmək üçündür.
    public bool Remove(T item)
    {
        return true;
    }

    // İterasiya obyektini geri qaytarır (IEnumerable<T>).
    public IEnumerator<T> GetEnumerator()
    {
        return ((IEnumerable<T>)elements).GetEnumerator();
    }

    // İterasiya obyektini geri qaytarır (IEnumerable).
    IEnumerator IEnumerable.GetEnumerator()
    {
        return (this as IEnumerable<T>).GetEnumerator();
    }
}