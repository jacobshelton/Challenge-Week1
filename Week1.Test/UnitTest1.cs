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
        /* my testing isnt working because it does not know what Xunit is...I simply did what we did
        for the Rectangle test...
        in the amount of time alloted I wasnt able to get that figured out... 
        My program works though! It can be tested through the command line, I made sure of that.
        */
