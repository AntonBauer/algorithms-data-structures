namespace DataStructures.Trees.BinarySearchTrees;

public record Node<TData>(TData Data, Node<TData>? Parent, Node<TData>? Left, Node<TData>? Right)
{
  public readonly TData Data = Data;
  public Node<TData>? Parent { get; set; } = Parent;
  public Node<TData>? Left { get; set; } = Left;
  public Node<TData>? Right { get; set; } = Right;

  public void Add(TData data, Comparer<TData> comparer)
  {
    if(comparer.Compare(Data, data) > 0)
    {
      if (Left is null)
        Left = new Node<TData>(data, this, default, default);
      else
        Left.Add(data, comparer);
    }
    else
    {
      if (Right is null)
        Right = new Node<TData>(data, this, default, default);
      else
        Right.Add(data, comparer);
    }
  }
}