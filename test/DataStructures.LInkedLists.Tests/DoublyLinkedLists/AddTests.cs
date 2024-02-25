using DataStructures.LinkedLists.DoublyLinkedLists;

namespace DataStructures.LinkedLists.Tests.DoublyLinkedLists;

[TestFixture]
public class AddTests
{
  [Test(TestOf = typeof(DoublyLinkedList<int>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void AddItemTest()
  {
    // Arrange
    var list = new DoublyLinkedList<int> { 1, 2 };

    // Assert
    Assert.That(list.Count, Is.EqualTo(2));
    Assert.Multiple(() =>
    {
      Assert.That(list[0], Is.EqualTo(1));
      Assert.That(list[1], Is.EqualTo(2));
    });
  }
  // Can add an item to a list with existing items
  [Test]
  [Category("Data structures")]
  [Category("Lists")]
  public void AddItemToListWithExistingItemsTest()
  {
    // Arrange
    var list = new DoublyLinkedList<int>
    {
        1,
        2
    };

    // Act
    list.Add(3);

    // Assert
    Assert.That(list.Count, Is.EqualTo(3), "Count is incorrect");
    Assert.That(list[0], Is.EqualTo(1), "Item at index 0 is incorrect");
    Assert.That(list[1], Is.EqualTo(2), "Item at index 1 is incorrect");
    Assert.That(list[2], Is.EqualTo(3), "Item at index 2 is incorrect");
  }
}