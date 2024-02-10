using System.Collections;

namespace DataStructures.LinkedLists.SinglyLinkedLists;

// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1?view=net-8.0

public class SinglyLinkedList<TData> : IEnumerable<TData>
{
  private Node<TData>? _head;
  public uint Count { get; private set; }

  public void Add(TData value)
  {
    _head = _head is null
      ? new Node<TData>(value, null)
      : new Node<TData>(value, _head);
    
    ++Count;
  }

  public void Clear()
  {
    _head = null;
    Count = 0;
  }

  public bool Contains(TData item)
  {
    if (Count == 0)
      return false;
    
    var current = _head;
    while (current is not null)
    {
      if (current.Data?.Equals(item) ?? false)
        return true;

      current = current.Next;
    }

    return false;
  }

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