using DataStructures.LinkedLists.SinglyLinkedLists;

namespace DataStructures.LInkedLists.Tests.SinglyLinkedLists;

[TestFixture]
public class AddTests
{
  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void EmptyListTests()
  {
    // Arrange
    var list = new SinglyLinkedList<int>();
    
    // Act
    var items = list.ToArray();

    // Assert
    Assert.That(items, Is.Empty, "New created list is not empty");
  }

  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void AddItemTest()
  {
    // Arrange
    var list = new SinglyLinkedList<int>();
    
    // Act
    list.Add(1);
    list.Add(2);

    var items = list.ToArray();
    
    // Assert
    Assert.That(items, Contains.Item(1), "Does not contain expected 1");
    Assert.That(items, Contains.Item(2), "Does not contain expected 2");
  }
}