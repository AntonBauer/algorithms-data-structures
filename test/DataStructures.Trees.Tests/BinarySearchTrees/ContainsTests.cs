using DataStructures.Trees.BinarySearchTrees;

namespace DataStructures.Trees.Tests.BinarySearchTrees;

[TestFixture]
public class ContainsTests
{
  [Test(TestOf = typeof(BinarySearchTree<>))]
  [Category("Data structures")]
  [Category("Trees")]
  public void Contains_WhenEmptyTree_ReturnsFalse()
  {
    // Arrange
    var tree = new BinarySearchTree<int>();

    // Act
    var result = tree.Contains(5);

    // Assert
    Assert.That(result, Is.False);
  }

  [Test(TestOf = typeof(BinarySearchTree<>))]
  [Category("Data structures")]
  [Category("Trees")]
  public void Contains_WhenItemInTree_ReturnsTrue()
  {
    // Arrange
    var tree = new BinarySearchTree<int> { 42, 8, 23, 16, 15, 4 };

    // Act
    var result = tree.Contains(4);

    // Assert
    Assert.That(result, Is.True);
  }

  [Test(TestOf = typeof(BinarySearchTree<>))]
  [Category("Data structures")]
  [Category("Trees")]
  public void Contains_WhenItemNotInTree_ReturnsFalse()
  {
    // Arrange
    var tree = new BinarySearchTree<int> { 42, 8, 23, 16, 15, 4 };

    // Act
    var result = tree.Contains(10);

    // Assert
    Assert.That(result, Is.False);
  }
}