namespace DataStructures.Trees.BinarySearchTrees;

internal record Node<TData>(TData Data, Node<TData>? Parent, Node<TData>? Left, Node<TData>? Right)
{
  public readonly TData Data = Data;

  public Node<TData>? Parent { get; set; } = Parent;
  public Node<TData>? Left { get; set; } = Left;
  public Node<TData>? Right { get; set; } = Right;

  public bool IsLeftChild() => Parent?.Left == this;

  public bool HasChildren() => Left is not null || Right is not null;

  public bool HasBothChildren() => Left is not null && Right is not null;
}