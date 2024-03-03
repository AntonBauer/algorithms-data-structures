namespace DataStructures.LinkedLists.DoublyLinkedLists;

internal sealed record Node<TData>(TData Data, Node<TData>? Prev, Node<TData>? Next)
{
    public TData Data { get; set; } = Data;

    public Node<TData>? Prev { get; set; } = Prev;

    public Node<TData>? Next { get; set; } = Next;
}