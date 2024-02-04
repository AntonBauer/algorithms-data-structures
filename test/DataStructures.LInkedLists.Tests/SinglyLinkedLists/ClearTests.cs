using DataStructures.LinkedLists.SinglyLinkedLists;

namespace DataStructures.LInkedLists.Tests.SinglyLinkedLists;

[TestFixture]
public class ClearTests
{
  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void ClearEmptyListTests()
  {
    // Arrange
    var list = new SinglyLinkedList<int>();

    // Act

    // Assert
    Assert.DoesNotThrow(() => list.Clear(), "Clear on empty list throws exception");
  }

  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void ClearEmptyListTest()
  {
    // Arrange
    var list = new SinglyLinkedList<int>();

    // Act
    list.Clear();

    // Assert
    var items = list.ToArray();
    Assert.That(items, Is.Empty, "Empty list is not empty after Clear");
  }

  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void ClearNonEmptyList()
  {
    // Arrange
    var list = new SinglyLinkedList<int>();
    list.Add(1);
    list.Add(2);

    // Act
    list.Clear();

    // Assert
    var items = list.ToArray();
    Assert.That(items, Is.Empty, "List is not empty after Clear");
    Assert.That(list.Count, Is.Zero, "List count is not zero after Clear");
  }
}