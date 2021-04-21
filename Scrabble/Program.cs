using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Program
  {
    public static void Main()
    {
      Word newWord = new Word();
      Console.WriteLine("Hi, welcome to the scrabble wordscore calculator!");
      Console.WriteLine("Please enter a word to be calculated:");
      string WordInput = Console.ReadLine();
      int Result = newWord.WordtoScore(WordInput);
      Console.WriteLine("The Scrabble score for " + WordInput + " is " + Result + ".");
    }
  }
}