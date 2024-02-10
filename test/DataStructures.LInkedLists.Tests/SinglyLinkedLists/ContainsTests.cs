using DataStructures.LinkedLists.SinglyLinkedLists;

namespace DataStructures.LInkedLists.Tests.SinglyLinkedLists;

[TestFixture]
public class ContainsTests
{
  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void EmptyListContainsNoItemsTest()
  {
    // Arrange
    var list = new SinglyLinkedList<int>();

    // Act
    var actual = list.Contains(42);

    // Assert
    Assert.That(actual, Is.False, "Empty list contains items");
  }

  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void ListContainsInsertedItemTest()
  {
    // Arrange
    var list = new SinglyLinkedList<int>
    {
      42,
      43
    };

    // Act
    var actual = list.Contains(42);
    
    // Assert
    Assert.That(actual, Is.True, "List does not contain inserted items");
  }
  
  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void ListDoesNotContainNotInsertedItemTest()
  {
    // Arrange
    var list = new SinglyLinkedList<int>
    {
      42,
      43
    };

    // Act
    var actual = list.Contains(24);
    
    // Assert
    Assert.That(actual, Is.False, "List contains not inserted item");
  }
}