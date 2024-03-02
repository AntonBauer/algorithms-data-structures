namespace Algorithms.Sorting.Tests;

[TestFixture]
public class CountingSortTests
{
  [Test(TestOf = typeof(CountingSortExtensions))]
  [Category("Algorithms")]
  [Category("Sorting")]
  public void Should_sort_array_in_ascending_order()
  {
    // Arrange
    int[] array = { 2, 5, 3, 0, 2, 3, 0, 3 };

    // Act
    var result = array.CountingSort();

    // Assert
    Assert.That(result, Is.EqualTo(new int[] { 0, 0, 2, 2, 3, 3, 3, 5 }));
  }
}