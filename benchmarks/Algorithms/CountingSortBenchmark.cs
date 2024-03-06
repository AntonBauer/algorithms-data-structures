using Algorithms.Sorting;
using BenchmarkDotNet.Attributes;

namespace Algorithms;

public class CountingSortBenchmark
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
  // Justification: is filled during setup
  private int[] data;
#pragma warning restore CS8618

  [Params(10, 100, 10_000, 1_000_000)]
  public int CollectionSize;

  [GlobalSetup]
  public void Setup()
  {
    data = new int[CollectionSize];
    var random = new Random(15);

    for (var i = 0; i < CollectionSize; i++)
      data[i] = random.Next();
  }

  [Benchmark]
  public int[] CountingSort() => data.ToArray().CountingSort();

  [Benchmark(Baseline = true)]
  public int[] BuiltInSort()
  {
    var toSort = data.ToArray();
    Array.Sort(toSort);

    return toSort;
  }
}