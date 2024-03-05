namespace Algorithms.Sorting;

public static class RadixSortExtensions
{
  /// <summary lang="en">
  /// Perform a Radix sort on the given array using the specified passes.
  /// </summary>
  /// <param name="array">Array to sort</param>
  /// <param name="passes">Mapping functions for Radix passes</param>
  /// <returns></returns>
  public static T[] RadixSort<T>(this T[] array, params Func<T, int>[] passes)
  {
    T[] sorted = [.. array];
    if (array.Length < 2)
      return sorted;

    foreach (var pass in passes)
      sorted = sorted.CountingSort(pass);

    return sorted;
  }
}