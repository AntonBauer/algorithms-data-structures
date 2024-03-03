namespace Algorithms.Sorting.Tests;

[TestFixture]
public class RadixSortTests
{
  [Test(TestOf = typeof(RadixSortExtensions))]
  [Category("Algorithms")]
  [Category("Sorting")]
  public void Should_sort_array_in_ascending_order()
  {
    // Arrange
    var array = new int[] { 329, 457, 657, 839, 436, 720, 355 };
    var passes = new Func<int, int>[]
    {
      i => i % 10,
      i => i / 10 % 10,
      i => i / 100
    };

    // Act
    var sorted = array.RadixSort(passes);

    // Assert
    var expected = new int[] { 329, 355, 436, 457, 657, 720, 839 };
    Assert.That(sorted, Is.EqualTo(expected));
  }
}