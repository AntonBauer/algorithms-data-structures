namespace DataStructures.Trees.BinarySearchTrees;

internal record Node<TData>(TData Data, Node<TData>? Parent, Node<TData>? Left, Node<TData>? Right)
{
  public readonly TData Data = Data;

  public Node<TData>? Parent { get; set; } = Parent;
  public Node<TData>? Left { get; set; } = Left;
  public Node<TData>? Right { get; set; } = Right;

  public bool IsLeftChild() => Parent?.Left == this;

  public bool HasNoChildren() => Left is null && Right is null;

  public bool HasBothChildren() => Left is not null && Right is not null;

  public void SetLeft(Node<TData> newLeft)
  {
    newLeft.DisjointFromParent();

    Left = newLeft;
    newLeft.Parent = this;
  }

  public void SetRight(Node<TData> newRight)
  {
    newRight.DisjointFromParent();

    Right = newRight;
    newRight.Parent = this;
  }

  public void DisjointFromParent()
  {
    if (Parent is null)
      return;

    if (IsLeftChild())
      Parent.Left = null;
    else
      Parent.Right = null;
  }
}