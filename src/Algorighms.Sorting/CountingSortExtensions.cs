namespace Algorithms.Sorting;

public static class CountingSortExtensions
{
  public static int[] CountingSort(this int[] array)
  {
    if (array.Length == 0 || array.Length == 1)
      return [.. array];

    var countingArray = array.CreateCountingArray();
    var outputArray = new int[array.Length];

    for (var i = 0; i < array.Length; i++)
      countingArray[array[i]]++;

    for (var i = 1; i < countingArray.Length; i++)
      countingArray[i] += countingArray[i - 1];

    for (var i = array.Length - 1; i >= 0; i--)
    {
      outputArray[countingArray[array[i]] - 1] = array[i];
      countingArray[array[i]]--;
    }

    return outputArray;
  }

  private static int[] CreateCountingArray(this int[] array)
  {
    var max = array.MinMax().Max;
    var countingArray = new int[max + 1];
    Array.Fill(countingArray, 0);

    return countingArray;
  }
}