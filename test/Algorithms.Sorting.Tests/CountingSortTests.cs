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
    var array = new int[] { 2, 5, 3, 0, 2, 3, 0, 3 };

    // Act
    var result = array.CountingSort(i => i);

    // Assert
    Assert.That(result, Is.EqualTo(new int[] { 0, 0, 2, 2, 3, 3, 3, 5 }));
  }


  [Test(TestOf = typeof(CountingSortExtensions))]
  [Category("Algorithms")]
  [Category("Sorting")]
  public void Should_sort_arbitrary_data_in_ascending_order()
  {
    // Arrange
    var array = new int[] { 2, 5, 3, 0, 2, 3, 0, 3 };
    var dict = array.Select(i => new KeyValuePair<int, string>(i, i.ToString())).ToArray();

    // Act
    var result = dict.ToArray().CountingSort(i => i.Key);

    // Assert
    var expected = new int[] { 0, 0, 2, 2, 3, 3, 3, 5 }.Select(i => new KeyValuePair<int, string>(i, i.ToString())).ToArray();
    Assert.That(result, Is.EqualTo(expected));
  }
}