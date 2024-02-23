using DataStructures.Trees.BinarySearchTrees;

namespace DataStructures.Trees.Tests.BinarySearchTrees;

public class RemoveTests
{
  [Test(TestOf = typeof(BinarySearchTree<>))]
  [Category("Data structures")]
  [Category("Trees")]
  public void Remove_NodeIsNotInTree_ReturnsFalse()
  {
    // Arrange
    var tree = new BinarySearchTree<int> { 42, 8, 23, 16, 15, 4 };

    // Act
    var result = tree.Remove(5);

    // Assert
    Assert.That(result, Is.False);
    Assert.That(tree, Is.EqualTo(new int[] { 42, 8, 23, 16, 15, 4 }));
  }

  [Test(TestOf = typeof(BinarySearchTree<>))]
  [Category("Data structures")]
  [Category("Trees")]
  public void Remove_NodeIsInTree_ReturnsTrue()
  {
    // Arrange
    var tree = new BinarySearchTree<int> { 42, 8, 23, 16, 15, 4 };

    // Act
    var result = tree.Remove(23);

    // Assert
    Assert.That(result, Is.True);
    Assert.That(tree, Is.EqualTo(new int[] { 4, 8, 15, 16, 42 }));
  }

  [Test(TestOf = typeof(BinarySearchTree<>))]
  [Category("Data structures")]
  [Category("Trees")]
  public void Remove_RootNode_ReturnsTrue()
  {
    // Arrange
    var tree = new BinarySearchTree<int> { 42, 8, 23, 16, 15, 4 };

    // Act
    var result = tree.Remove(42);

    // Assert
    Assert.That(result, Is.True);
    Assert.That(tree, Is.EqualTo(new int[] { 4, 8, 15, 16, 23 }));
  }

  [Test(TestOf = typeof(BinarySearchTree<>))]
  [Category("Data structures")]
  [Category("Trees")]
  public void Remove_RootNode_As_Only_Node_ReturnsTrue()
  {
    // Arrange
    var tree = new BinarySearchTree<int> { 42 };

    // Act
    var result = tree.Remove(42);

    // Assert
    Assert.That(result, Is.True);
    Assert.That(tree, Is.Empty);
  }
}