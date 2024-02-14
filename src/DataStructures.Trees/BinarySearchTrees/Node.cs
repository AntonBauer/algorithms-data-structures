namespace DataStructures.Trees.BinarySearchTrees;

internal record Node<TData>(TData Data, Node<TData>? Parent, Node<TData>? Left, Node<TData>? Right)
{
  public readonly TData Data = Data;
  
  public Node<TData>? Parent { get; private set; } = Parent;
  public Node<TData>? Left { get; set; } = Left;
  public Node<TData>? Right { get; set; } = Right;

}