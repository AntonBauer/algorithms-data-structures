using DataStructures.LinkedLists.SinglyLinkedLists;

namespace DataStructures.LInkedLists.Tests.SinglyLinkedLists;

using NUnit.Framework;

[TestFixture]
public class IndexOfTests
{
  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void IndexOf_WhenItemExists_ReturnsCorrectIndex()
  {
    // Arrange
    var list = new SinglyLinkedList<int>
    {
      5,
      10,
      15
    };

    // Act
    var index = list.IndexOf(5);

    // Assert
    Assert.That(index, Is.EqualTo(2));
  }

  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void IndexOf_WhenItemDoesNotExist_ReturnsMinusOne()
  {
    // Arrange
    var list = new SinglyLinkedList<string>
    {
      "apple",
      "banana",
      "orange"
    };

    // Act
    var index = list.IndexOf("grape");

    // Assert
    Assert.That(index, Is.EqualTo(-1));
  }

  [Test(TestOf = typeof(SinglyLinkedList<>))]
  [Category("Data structures")]
  [Category("Lists")]
  public void IndexOf_WhenListIsEmpty_ReturnsMinusOne()
  {
    // Arrange
    var list = new SinglyLinkedList<double>();

    // Act
    var index = list.IndexOf(3.14);

    // Assert
    Assert.That(index, Is.EqualTo(-1));
  }
}