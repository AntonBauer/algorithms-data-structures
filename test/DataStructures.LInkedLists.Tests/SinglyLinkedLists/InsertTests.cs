using DataStructures.LinkedLists.SinglyLinkedLists;

namespace DataStructures.LInkedLists.Tests.SinglyLinkedLists;

[TestFixture]
public class InsertTests
{
  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void Insert_WhenListIsEmpty_InsertsItemAtFirstPosition()
  {
    // Arrange
    var list = new SinglyLinkedList<int>();

    // Act
    list.Insert(0, 5);

    // Assert
    CollectionAssert.AreEquivalent(new[] { 5 }, list);
  }

  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void Insert_WhenIndexIsZero_InsertsItemAtFirstPosition()
  {
    // Arrange
    var list = new SinglyLinkedList<string>
    {
      "apple",
      "banana"
    };

    // Act
    list.Insert(0, "orange");

    // Assert
    CollectionAssert.AreEqual(new[] { "orange", "banana", "apple" }, list);
  }

  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void Insert_WhenIndexIsGreaterThanZero_InsertsItemAtSpecifiedPosition()
  {
    // Arrange
    var list = new SinglyLinkedList<int>
    {
      1,
      2
    };

    // Act
    list.Insert(1, 3);

    // Assert
    CollectionAssert.AreEqual(new[] { 2, 3, 1 }, list);
    Assert.That(list, Has.Count.EqualTo(3));
  }

  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void Insert_WhenIndexIsOutOfRange_ThrowsArgumentOutOfRangeException()
  {
    // Arrange
    var list = new SinglyLinkedList<int> { 10 };

    // Act & Assert
    Assert.Throws<ArgumentOutOfRangeException>(() => list.Insert(2, 5));
  }
}