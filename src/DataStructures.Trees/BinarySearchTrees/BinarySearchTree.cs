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
    {
      _root = new Node<TData>(item, null, null, null);
      ++Count;
      return;
    }

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

    RemoveNode(node);
    --Count;
    return true;
  }

  public IEnumerator<TData> GetEnumerator()
  {
    if (Count == 0)
      yield break;

    foreach (var item in GetNodeData(_root!))
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

  private void RemoveNode(Node<TData> node)
  {
    if (node.HasNoChildren())
    {
      if (node == _root)
        _root = null;
      else
        node.DisjointFromParent();
    }
    else if (node.HasBothChildren())
      RemoveNodeWithBothChildren(node);
    else
      RemoveNodeWithOnlyChild(node);
  }

  private void RemoveNodeWithBothChildren(Node<TData> node)
  {
    if (node.Left is null || node.Right is null)
      throw new Exception("Node must have both children");

    var successor = FindSuccessorOf(node);
    if (successor is null)
      throw new Exception("Successor not found");

    var parent = node.Parent;
    if (parent is not null)
    {
      if (node.IsLeftChild())
        parent.SetLeft(successor);
      else
        parent.SetRight(successor);
    }
    else
      _root = node;

    successor.SetLeft(node.Left);
    successor.SetRight(node.Right);
  }

  private void RemoveNodeWithOnlyChild(Node<TData> node)
  {
    var child = node.Left ?? node.Right;
    if (node.Left is not null && node.Right is not null || child is null)
      throw new Exception("Node should have exactly one child");

    if (node.Parent is null)
    {
      _root = child;
      return;
    }

    if (node.IsLeftChild())
      node.Parent.SetLeft(child);
    else
      node.Parent.SetRight(child);
  }


  private static Node<TData>? FindSuccessorOf(Node<TData> node)
  {
    if (node.Right is not null)
      return FindMinimumFrom(node.Right);

    var current = node;
    var parent = current.Parent;
    while (parent is not null && current == parent.Right)
    {
      current = parent;
      parent = current.Parent;
    }

    return parent;
  }

  private static Node<TData> FindMinimumFrom(Node<TData> node)
  {
    var current = node;
    while (current.Left is not null)
      current = current.Left;

    return current;
  }

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