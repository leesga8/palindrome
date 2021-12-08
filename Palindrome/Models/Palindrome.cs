using System;
using System.Collections.Generic;

namespace Palindrome
{
  public class InputChecker
  { 
    public bool IsItAPalindrome(string word)
    {
      char[] reversedArray = word.ToCharArray();
      Array.Reverse(reversedArray);
      string reversed = new string(reversedArray);
      if (word.Equals(reversed)) return true;
        
      return false; 
    }
  }
}