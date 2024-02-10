using System.Collections;

namespace DataStructures.LinkedLists.SinglyLinkedLists;

public class SinglyLinkedList<TData> : IList<TData>
{
  private Node<TData>? _head;

  public int Count { get; private set; }

  public bool IsReadOnly => false;
  
  public TData this[int index]
  {
    get => throw new NotImplementedException();
    set => throw new NotImplementedException();
  }

  public void Add(TData value)
  {
    _head = _head is null
      ? new Node<TData>(value, null)
      : new Node<TData>(value, _head);
    
    ++Count;
  }

  public bool Remove(TData item)
  {
    if (Count == 0)
      return false;

    if (_head!.Data?.Equals(item) ?? false)
    {
      _head = _head.Next;
      return true;
    }
    
    var current = _head.Next;
    var previous = _head;
    while (current is not null)
    {
      if (current.Data?.Equals(item) ?? false)
      {
        previous.Next = current.Next;
        return true;
      }

      previous = current;
      current = current.Next;
    }

    return false;
  }
  
  public void Clear()
  {
    _head = null;
    Count = 0;
  }

  public bool Contains(TData item) => IndexOf(item) > 0;

  public int IndexOf(TData item)
  {
    if (Count == 0)
      return -1;
    
    var currentIndex = 0;
    var currentItem = _head;
    while (currentItem is not null)
    {
      if (currentItem.Data?.Equals(item) ?? false)
        return currentIndex;

      ++currentIndex;
      currentItem = currentItem.Next;
    }

    return -1;
  }

  public void Insert(int index, TData item)
  {
    throw new NotImplementedException();
  }

  public void RemoveAt(int index)
  {
    throw new NotImplementedException();
  }


  public void CopyTo(TData[] array, int arrayIndex)
  {
    throw new NotImplementedException();
  }
  
  public IEnumerator<TData> GetEnumerator()
  {
    var current = _head;
    while (current is not null)
    {
      yield return current.Data;
      current = current.Next;
    }
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}