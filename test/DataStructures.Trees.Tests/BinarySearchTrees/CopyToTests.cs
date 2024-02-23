using DataStructures.Trees.BinarySearchTrees;

namespace DataStructures.Trees.Tests.BinarySearchTrees;

[TestFixture]
public class CopyToTests
{
  
  [Test(TestOf = typeof(BinarySearchTree<>))]
  [Category("Data structures")]
  [Category("Trees")]
  public void ToArray_Should_Return_SortedArray()
  {
    // Arrange
    var tree = new BinarySearchTree<int> { 42, 8, 23, 16, 15, 4 };
    
    // Act
    var array = tree.ToArray();
    
    // Assert
    Assert.That(array, Is.EqualTo(new[] { 4, 8, 15, 16, 23, 42 }));
  }
}