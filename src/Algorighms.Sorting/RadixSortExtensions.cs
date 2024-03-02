namespace Algorithms.Sorting;

public static class RadixSortExtensions
{
  /// <summary lang="en">
  /// Perform a radix sort on the given array using the specified passes.
  /// </summary>
  /// <param name="array">Array to sort</param>
  /// <param name="passes">Radix passes</param>
  /// <returns></returns>
  public static int[] RadixSort(this int[] array, params Func<int, int>[] passes)
  {
    if (array.Length < 2)
      return [.. array];

    var sorted = array.ToArray();

    foreach (var pass in passes)
    {
    }

    return sorted;
  }
}