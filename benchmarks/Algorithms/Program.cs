using Algorithms;
using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run<CountingSortBenchmark>();