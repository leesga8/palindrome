using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class InputCheckerTests
  {
    [TestMethod]
    public void IsItAPalindrome_WillCheckIfWordsAreEqual_True()
    {
      InputChecker palindrome = new InputChecker();
      Assert.AreEqual(true, palindrome.IsItAPalindrome("lol"));
    }

        [TestMethod]
    public void IsItAPalindrome_WillCheckIfNotWordsAreEqual_False()
    {
      InputChecker palindrome = new InputChecker();
      Assert.AreEqual(false, palindrome.IsItAPalindrome("lola"));
    }
  }
}
