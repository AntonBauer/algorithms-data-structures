
using System.Collections;

public class DoublyLinkedList<TData> : IList<TData>
{
    public TData this[int index] { get; set; }

    public int Count { get; }
    public bool IsReadOnly { get; }

    public void Add(TData item)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(TData item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(TData[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<TData> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public int IndexOf(TData item)
    {
        throw new NotImplementedException();
    }

    public void Insert(int index, TData item)
    {
        throw new NotImplementedException();
    }

    public bool Remove(TData item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}