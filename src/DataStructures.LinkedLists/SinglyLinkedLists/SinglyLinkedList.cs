using System.Collections;

namespace DataStructures.LinkedLists.SinglyLinkedLists;

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