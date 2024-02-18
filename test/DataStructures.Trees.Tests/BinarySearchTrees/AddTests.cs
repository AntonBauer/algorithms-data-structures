using DataStructures.Trees.BinarySearchTrees;

namespace DataStructures.Trees.Tests.BinarySearchTrees;

[TestFixture]
public class AddTests
{
  [Test(TestOf = typeof(BinarySearchTree<>))]
  [Category("Data structures")]
  [Category("Trees")]
  public void Add_ItemToEmptyTree_ItemAdded()
  {
    // Arrange
    var tree = new BinarySearchTree<int>
    {
      5,
      3,
      8,
      9,
      7
    };

    // Assert
    Assert.That(tree, Does.Contain(7));
  }

  [Test(TestOf = typeof(BinarySearchTree<>))]
  [Category("Data structures")]
  [Category("Trees")]
  public void Add_ItemToNonEmptyTree_ItemAdded()
  {
    // Arrange
    var tree = new BinarySearchTree<int>
    {
      5,
      3
    };

    // Assert
    Assert.That(tree, Does.Contain(3));
  } 
}