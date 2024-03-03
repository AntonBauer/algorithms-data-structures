namespace Algorithms.Sorting;

public static class RadixSortExtensions
{
  /// <summary lang="en">
  /// Perform a radix sort on the given array using the specified passes.
  /// </summary>
  /// <param name="array">Array to sort</param>
  /// <param name="passes">Radix passes</param>
  /// <returns></returns>
  public static T[] RadixSort<T>(this T[] array, params Func<T, int>[] passes)
  {
    if (array.Length < 2)
      return [.. array];

    var sorted = array.ToArray();

    foreach (var pass in passes)
      sorted = sorted.CountingSort(pass);

    return sorted;
  }
}