using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System;
using System.Collections.Generic;


namespace Scrabble.Tests
{
    [TestClass]
    public class ScrabbleTests
    {
        [TestMethod]
        public void LetterScore_CalculateScoreForALetter_1()
        {
            //Arrange
            Word newWord = new Word();
            //Act
            int result = newWord.LetterScore('A');
            //Assert
            Assert.AreEqual(1, result);
        }
 
        [TestMethod]
        public void LetterScore_calculateScoreForALetterK_5()
        {
            Word newWord = new Word();
            int testResult = newWord.LetterScore('K');
            int expected = 5;
            Assert.AreEqual(expected, testResult);
        }

        [TestMethod]
        public void WordtoLetter_calculateScoreforaWordDay_7()
        {
            Word newWord = new Word();
            int testResult = newWord.WordtoLetter("Day");
            int expected = 7;
            Assert.AreEqual(expected, testResult);
        }

        // [TestMethod]
        // public void WordSum_CalculateScoreForAllLettersInWord_13()
        // {
        //     //Arrange
        //     Word newWord = new Word("homonym");
        //     //Act
        //     int result = newWord.LetterScore('A');
        //     //Assert
        //     Assert.AreEqual(1, result);
        // }
    }
}