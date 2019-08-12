using Week1.Domain;
using Xunit;

namespace Week1.Test
{
  public class PalindromeTests
  {
    [Fact]
    public void Test_Palindrome()
    {
      //arrange
      var palindrome = new Palindrome();
      var expected = true;
      var test = civic;

      //act
      var actual = palindrome.PalindromeFunction(test);

      //assert
      Assert.True(expected == actual);
    }
  }
}
