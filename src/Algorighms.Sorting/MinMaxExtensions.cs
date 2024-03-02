public static class MinMaxExtensions
{
  public static (T Min, T Max) MinMax<T>(this T[] array) where T : IComparable<T>
  {
    if (array.Length == 0)
      throw new ArgumentOutOfRangeException(nameof(array), "Array is empty");

    var min = array[0];
    var max = array[0];

    for (var i = 1; i < array.Length; i++)
    {
      if (array[i].CompareTo(min) < 0)
        min = array[i];
      if (array[i].CompareTo(max) > 0)
        max = array[i];
    }

    return (min, max);
  }
}