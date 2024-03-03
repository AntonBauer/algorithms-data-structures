namespace DataStructures.SuffixArrays;

public static class SuffixArrayExtensions
{
  /// <summary>
  /// Implementation of Karkkainen-Sanders algorighm
  /// </summary>
  /// <param name="str">String to calculate suffix array for</param>
  /// <returns>Suffix array</returns>
  public static int[] CalculateSuffixArray(this string str)
  {
    // assign numbers to every char
    // pad string to mod 3 == 0

    // split into triplets
    // take triplets starting at i mod 3 == 1 and i mod 3 == 2
    // assign numbers by radix sort triplets
    // if numbers are not distinct, recursively call suffix array on this new array
    
    // sort triplets starting at i mod 3 == 0

    // Merge triplets arrays

    return Array.Empty<int>();
  }
}
