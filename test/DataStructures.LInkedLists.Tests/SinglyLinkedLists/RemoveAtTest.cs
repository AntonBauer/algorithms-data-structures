using DataStructures.LinkedLists.SinglyLinkedLists;

namespace DataStructures.LInkedLists.Tests.SinglyLinkedLists;

[TestFixture]
public class RemoveAtTest
{
  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void RemoveAt_WhenIndexIsZero_ShouldRemoveFirstItem()
  {
    // Arrange
    var list = new SinglyLinkedList<int>
    {
      1,
      2,
      3
    };

    // Act
    list.RemoveAt(0);

    // Assert
    Assert.That(list[0], Is.EqualTo(2));
    Assert.That(list[1], Is.EqualTo(1));
    Assert.That(list.Count, Is.EqualTo(2));
  }

  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void RemoveAt_WhenIndexIsMiddle_ShouldRemoveItemAtMiddle()
  {
    // Arrange
    var list = new SinglyLinkedList<int>
    {
      1,
      2,
      3
    };

    // Act
    list.RemoveAt(1);

    // Assert
    Assert.That(list[0], Is.EqualTo(3));
    Assert.That(list[1], Is.EqualTo(1));
    Assert.That(list.Count, Is.EqualTo(2));
  }

  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void RemoveAt_WhenIndexIsLast_ShouldRemoveLastItem()
  {
    // Arrange
    var list = new SinglyLinkedList<int>
    {
      1,
      2,
      3
    };

    // Act
    list.RemoveAt(2);

    // Assert
    Assert.That(list[0], Is.EqualTo(3));
    Assert.That(list[1], Is.EqualTo(2));
    Assert.That(list.Count, Is.EqualTo(2));
  }

  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void RemoveAt_WhenIndexIsOutOfRange_ShouldThrowException()
  {
    // Arrange
    var list = new SinglyLinkedList<int> { 1 };

    // Act and Assert
    Assert.Throws<ArgumentOutOfRangeException>(() => list.RemoveAt(1));
  }
} 