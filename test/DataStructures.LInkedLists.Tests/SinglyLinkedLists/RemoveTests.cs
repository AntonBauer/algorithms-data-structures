using DataStructures.LinkedLists.SinglyLinkedLists;

namespace DataStructures.LInkedLists.Tests.SinglyLinkedLists;

[TestFixture]
public class RemoveTests
{
  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void Remove_WhenItemExists_RemovesItemAndReturnsTrue()
  {
    // Arrange
    var list = new SinglyLinkedList<int>
    {
      5,
      10,
      15
    };

    // Act
    var result = list.Remove(10);

    // Assert
    Assert.That(result, Is.True);
    CollectionAssert.AreEquivalent(new[] { 5, 15 }, list);
  }

  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void Remove_WhenItemDoesNotExist_ReturnsFalse()
  {
    // Arrange
    var list = new SinglyLinkedList<string>
    {
      "apple",
      "banana",
      "orange"
    };

    // Act
    var result = list.Remove("grape");

    // Assert
    var expected = new[] { "apple", "banana", "orange" };

    Assert.That(result, Is.False);
    CollectionAssert.AreEquivalent(expected, list);
  }

  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void Remove_WhenListIsEmpty_ReturnsFalse()
  {
    // Arrange
    // ReSharper disable once CollectionNeverUpdated.Local
    var list = new SinglyLinkedList<double>();

    // Act
    var result = list.Remove(3.14);

    // Assert
    Assert.That(result, Is.False);
    CollectionAssert.IsEmpty(list);
  }
}