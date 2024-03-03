using System.Collections;

namespace DataStructures.LinkedLists.SinglyLinkedLists;

public class SinglyLinkedList<TData> : IList<TData>
{
  private Node<TData>? _head;

  public int Count { get; private set; }

  public bool IsReadOnly => false;

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
      --Count;
      return true;
    }

    var current = _head.Next;
    var previous = _head;
    while (current is not null)
    {
      if (current.Data?.Equals(item) ?? false)
      {
        previous.Next = current.Next;
        --Count;
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

  public bool Contains(TData item) => IndexOf(item) >= 0;

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
    if (index < 0 || (index >= Count && Count != 0))
      throw new ArgumentOutOfRangeException(nameof(index), index, "Index is out of range");

    if (index == 0)
    {
      Add(item);
      return;
    }

    var current = _head;
    var currentIndex = 0;

    while (currentIndex + 1 < index)
    {
      current = current!.Next;
      ++currentIndex;
    }

    var newNode = new Node<TData>(item, current!.Next);
    current.Next = newNode;
    ++Count;
  }

  public void RemoveAt(int index)
  {
    if (index < 0 || index >= Count)
      throw new ArgumentOutOfRangeException(nameof(index), index, "Index is out of range");

    if (index == 0)
      _head = _head!.Next;
    else
    {
      var prevItem = _head;
      var currentItem = _head!.Next;
      var currentIndex = 1;
      while (currentIndex < index)
      {
        prevItem = currentItem;
        currentItem = currentItem!.Next;
        ++currentIndex;
      }

      prevItem!.Next = currentItem!.Next;
    }

    --Count;
  }

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

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}