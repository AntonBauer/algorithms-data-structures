using System.Collections;

namespace DataStructures.LinkedLists.SinglyLinkedLists;

public class SinglyLinkedList<TData> : IEnumerable<TData>
{
  private Node<TData>? _head;

  public SinglyLinkedList()
  {
    _head = null;
  }

  public void Add(TData value) =>
    _head = _head is null
      ? new Node<TData>(value, null)
      : new Node<TData>(value, _head);

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