using System.Collections;

namespace DataStructures.Trees.BinarySearchTrees;

public class BinarySearchTree<TData> : ICollection<TData>
{
  private Comparer<TData> _comparer;
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

    _root!.Add(item, _comparer);
    ++Count;
  }

  public void Clear()
  {
    _root = null;
    Count = 0;
  }

  public bool Contains(TData item) => throw new NotImplementedException();

  public void CopyTo(TData[] array, int arrayIndex)
  {
    throw new NotImplementedException();
  }

  public bool Remove(TData item) => throw new NotImplementedException();

  public IEnumerator<TData> GetEnumerator() => throw new NotImplementedException();

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}