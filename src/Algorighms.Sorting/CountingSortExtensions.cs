namespace Algorithms.Sorting;

public static class CountingSortExtensions
{
  public static T[] CountingSort<T>(this T[] array, Func<T, int> intMap)
  {
    if (array.Length < 2)
      return [.. array];
    
    var intArray = array.Select(intMap).ToArray();
    var countingArray = intArray.CreateCountingArray();
    var outputArray = new T[array.Length];

    for (var i = 0; i < array.Length; i++)
      countingArray[intArray[i]]++;

    for (var i = 1; i < countingArray.Length; i++)
      countingArray[i] += countingArray[i - 1];

    for (var i = array.Length - 1; i >= 0; i--)
    {
      outputArray[countingArray[intArray[i]] - 1] = array[i];
      countingArray[intArray[i]]--;
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