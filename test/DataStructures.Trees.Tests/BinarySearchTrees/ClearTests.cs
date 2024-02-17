using DataStructures.Trees.BinarySearchTrees;

namespace DataStructures.Trees.Tests.BinarySearchTrees;

[TestFixture]
public class ClearTests
{
  [Test(TestOf = typeof(BinarySearchTree<>))]
  [Category("Data structures")]
  [Category("Trees")]
  public void Clear_EmptyTree_CountIsZero()
  {
    // Arrange
    var tree = new BinarySearchTree<int>();

    // Act
    tree.Clear();

    // Assert
    Assert.That(tree, Is.Empty);
  }
  
  [Test(TestOf = typeof(BinarySearchTree<>))]
  [Category("Data structures")]
  [Category("Trees")]
  public void Clear_NonEmptyTree_CountIsZero()
  {
    // Arrange
    var tree = new BinarySearchTree<int> { 5, 3};

    // Act
    tree.Clear();

    // Assert
    Assert.That(tree, Is.Empty);
  }}