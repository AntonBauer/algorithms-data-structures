using System.Collections;

namespace DataStructures.LinkedLists.DoublyLinkedLists;

public class DoublyLinkedList<TData> : IList<TData>
{
  private Node<TData>? _head;
  private Node<TData>? _tail;

  public TData this[int index]
  {
    get
    {
      if (index < 0 || index >= Count)
        throw new ArgumentOutOfRangeException(nameof(index), index, "Index is out of range");

      var currentIndex = 0;
      var currentItem = _head;
      while (currentIndex < index)
      {
        currentItem = currentItem!.Next;
        ++currentIndex;
      }

      return currentItem!.Data;
    }
    set => Insert(index, value);
  }

  public int Count { get; private set; }

  public bool IsReadOnly => false;

  public void Add(TData item)
  {
    if (Count == 0)
      _head = _tail = new Node<TData>(item, null, null);
    else
    {
      var node = new Node<TData>(item, _tail, null);
      _tail!.Next = node;
      _tail = node;
    }

    ++Count;
  }

  public void Clear()
  {
    _head = _tail = null;
    Count = 0;
  }

  public bool Contains(TData item) => IndexOf(item) >= 0;

  public void CopyTo(TData[] array, int arrayIndex)
  {
    if (arrayIndex + Count > array.Length)
      throw new ArgumentOutOfRangeException(nameof(arrayIndex), arrayIndex, "Index is out of range");

    foreach (var item in this)
      array[arrayIndex++] = item;
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
    if (index < 0 || index >= Count && Count != 0)
      throw new ArgumentOutOfRangeException(nameof(index), index, "Index is out of range");

    var current = _head;
    var currentIndex = 0;

    while (currentIndex + 1 < index)
    {
      current = current!.Next;
      ++currentIndex;
    }

    var newNode = new Node<TData>(item, current, current!.Next);
    current.Next = newNode;
    current.Next.Prev = newNode;

    ++Count;
  }

  public bool Remove(TData item)
  {
    if (Count == 0)
      return false;

    var current = _head;
    while (current is not null)
    {
      if (current.Data?.Equals(item) ?? false)
      {
        Remove(current);
        return true;
      }

      current = current.Next;
    }

    return false;
  }

  public void RemoveAt(int index)
  {
    if (index < 0 || index >= Count)
      throw new ArgumentOutOfRangeException(nameof(index), index, "Index is out of range");

    var currentItem = _head;
    var currentIndex = 0;
    while (currentIndex < index)
    {
      currentItem = _head!.Next;
      ++currentIndex;
    }

    Remove(currentItem!);
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

  private void Remove(Node<TData> node)
  {
    if (node.Prev is not null)
      node.Prev.Next = node.Next;
    if (node.Next is not null)
      node.Next.Prev = node.Prev;

    --Count;
  }
}