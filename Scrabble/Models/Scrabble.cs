using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
    public class Word
    {
        private static Dictionary<char, int> letterValue = new Dictionary<char, int>()
        {
            {'A', 1},
            {'B', 3}
        };
        public int LetterScore(char letter) {
            Console.Write(letter);
            return 0;
        }
    }
 }
        
 
        

