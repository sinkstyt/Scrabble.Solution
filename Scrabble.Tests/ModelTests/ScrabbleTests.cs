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
        public void EnterLetterA_GetScore_Score()
        {
            //Arrange
            Word newWord = new Word();
            //Act
            int result = newWord.LetterScore('A');
            //Assert
            Assert.AreEqual(1, result);
        }
    }
}
