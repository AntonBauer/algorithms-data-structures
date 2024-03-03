using DataStructures.SuffixArrays;

namespace DataStructures.SuffixArray.Tests;

[TestFixture]
public class SuffixArrayTests
{

  [Test]
  [Category("Data structures")]
  [Category("Suffix arrays")]
  [TestCaseSource(nameof(TestCases))]
  public void Should_create_correct_suffix_array(string str, int[] expectedArray)
  {
    var actualArray = str.CalculateSuffixArray();
    Assert.That(actualArray, Is.EqualTo(expectedArray));
  }

  public static IEnumerable<TestCaseData> TestCases()
  {
    yield return new TestCaseData("banana", new int[] { 6, 4, 2, 1, 5, 3 }).SetName("Banana");
    yield return new TestCaseData("mississippi", new int[] { 10, 7, 4, 1, 0, 9, 8, 6, 3, 5, 2 }).SetName("Mississippi");
  }
}