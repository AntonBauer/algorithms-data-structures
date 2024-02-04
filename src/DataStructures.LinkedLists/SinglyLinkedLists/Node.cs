namespace DataStructures.LinkedLists.SinglyLinkedLists;

internal sealed record Node<TData>(TData Data, Node<TData>? Next);