using DataStructures.LinkedLists.SinglyLinkedLists;

namespace DataStructures.LInkedLists.Tests.SinglyLinkedLists;

[TestFixture]
public class CountTests
{
  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void EmptyListHasCountZeroTest()
  {
    // Arrange
    var list = new SinglyLinkedList<int>();
    
    // Act
    var actual = list.Count;
    
    // Assert
    Assert.That(actual, Is.Zero, "Count of empty list is zero");
    Assert.That(actual, Is.Not.Negative, "Count of list is negative");
  }

  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void ListHasCorrectCountAfterAddTest()
  {
    // Arrange
    var list = new SinglyLinkedList<int>
    {
      1,
      2
    };

    // Act
    var actual = list.Count;
    
    // Assert
    Assert.That(actual, Is.Not.Zero, "Count of list after add is zero");
    Assert.That(actual, Is.Not.Negative, "Count of list is negative");
    Assert.That(actual, Is.EqualTo(2), "Unexpected count value");
  }
}