using System;
using System.Collections.Generic;
using Palindrome;
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Palindrome Checker");
      Console.WriteLine("=========================================");
      Console.WriteLine("Enter a word to see if it is a palindrome");
      string answer = Console.ReadLine();

      InputChecker input = new InputChecker();
      if(!input.IsItAPalindrome(answer)) {
        Console.WriteLine("=========================================");
        Console.WriteLine(answer + " is not a palindrome");
      } else{
        Console.WriteLine("=========================================");
        Console.WriteLine(answer + " is a palindrome");
      }  
    } 
  } 
