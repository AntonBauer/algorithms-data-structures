using System.Collections;

namespace DataStructures.Trees.BinarySearchTrees;

public class BinarySearchTree<TData> : ICollection<TData>
{
  private readonly Comparer<TData> _comparer;
  private Node<TData>? _root;

  public int Count { get; private set; }

  public bool IsReadOnly => false;

  public BinarySearchTree() : this(Comparer<TData>.Default)
  {
  }

  public BinarySearchTree(IComparer<TData> comparer)
  {
    var dataType = typeof(TData);
    // ToDo: create comparer delegate
    // dataType.GetMethod(nameof(IComparable<TData>.CompareTo)).CreateDelegate()

    _comparer = dataType.IsAssignableTo(typeof(IComparable<TData>))
      ? Comparer<TData>.Default
      : Comparer<TData>.Create(comparer.Compare);
  }

  public void Add(TData item)
  {
    if (Count == 0)
      _root = new Node<TData>(item, null, null, null);


    var current = _root;
    while (true)
    {
      if (_comparer.Compare(current!.Data, item) >= 0)
      {
        if (current.Left is null)
        {
          current.Left = new Node<TData>(item, current, default, default);
          break;
        }

        current = current.Left;
      }
      else
      {
        if (current.Right is null)
        {
          current.Right = new Node<TData>(item, current, default, default);
          break;
        }

        current = current.Right;
      }
    }

    ++Count;
  }

  public void Clear()
  {
    _root = null;
    Count = 0;
  }

  public bool Contains(TData item)
  {
    if (Count == 0)
      return false;

    return FindNodeContaining(item) is not null;
  }

  public void CopyTo(TData[] array, int arrayIndex)
  {
    if (arrayIndex + Count > array.Length)
      throw new ArgumentOutOfRangeException(nameof(arrayIndex), arrayIndex, "The index is out of range");

    foreach (var item in this)
      array[arrayIndex++] = item;
  }

  public bool Remove(TData item)
  {
    if (Count == 0)
      return false;
    
    var node = FindNodeContaining(item);
    if (node is null)
      return false;

    if (!node.HasChildren())
    {
      if (node.IsLeftChild())
        node.Parent!.Left = null;
      else
        node.Parent!.Right = null;

      return true;
    }

    if (node.HasBothChildren())
    {
      var successor = FindSuccessorOf(node);
      throw new NotImplementedException();
    }

    var child = node.Left ?? node.Right;

    if (node.IsLeftChild())
      node.Parent!.Left = child;
    else
      node.Parent!.Right = child;

    child!.Parent = node.Parent;

    return true;
  }

  public IEnumerator<TData> GetEnumerator()
  {
    if (Count == 0)
      yield break;

    foreach(var item in GetNodeData(_root!))
      yield return item;
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

  private Node<TData>? FindNodeContaining(TData item)
  {
    var current = _root;
    while (current is not null)
    {
      var comparison = _comparer.Compare(current.Data, item);
      if (comparison == 0)
        return current;

      current = comparison >= 0
        ? current.Left
        : current.Right;
    }

    return null;
  }

  private Node<TData> FindSuccessorOf(Node<TData> node) => throw new NotImplementedException();
  
  private static TData[] GetNodeData(Node<TData> node)
  {
    var left = node.Left is not null
      ? GetNodeData(node.Left)
      : Array.Empty<TData>();
    
    var current = new[] { node.Data };

    var right = node.Right is not null
      ? GetNodeData(node.Right)
      : Array.Empty<TData>();

    var result = new TData[left.Length + current.Length + right.Length];
    left.CopyTo(result, 0);
    current.CopyTo(result, left.Length);
    right.CopyTo(result, left.Length + current.Length);

    return result;
  }
}