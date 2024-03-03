using DataStructures.SuffixArrays;

namespace DataStructures.SuffixArray.Tests;

[TestFixture]
public class SuffixArrayTests
{

  [Test]
  [Category("Data structures")]
  [Category("Suffix arrays")]
  public void Should_create_correct_suffix_array()
  {
    // Arrange
    var str = "banana";

    // Act
    var result = str.CalculateSuffixArray();

    // Assert
    Assert.That(result, Is.EqualTo(new int[] { 6, 4, 2, 1, 5, 3 }));
  }
}