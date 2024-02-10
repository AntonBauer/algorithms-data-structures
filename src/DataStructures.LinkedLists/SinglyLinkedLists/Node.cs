namespace DataStructures.LinkedLists.SinglyLinkedLists;

internal sealed record Node<TData>(TData Data, Node<TData>? Next)
{
  public readonly TData Data = Data;

  public Node<TData>? Next { get; set; } = Next;
}