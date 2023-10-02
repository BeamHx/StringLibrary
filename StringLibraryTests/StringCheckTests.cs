using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using StringLibrary;
using System.Linq;

namespace StringLibraryTests
{
    [TestClass]
    public class StringCheckTests
    {
        /// <summary>
        ///     
        /// </summary>
        [TestMethod]
        public void StringCheck_BOBA_ReturnedABO()
        {
            // Arrange
            string str = "BOBA";
            List<char> expected = new List<char>() { 'A', 'B', 'O' };
            //Act
            List<char> action = StringCheck.GetLetters(str);
            //Assert
            CollectionAssert.AreEqual(expected, action);
        }
        /// <summary>
        /// АНАНАС - А, Н, С
        /// </summary>
        [TestMethod]
        public void StringCheck_Ананас_ReturnedАНС()
        {
            // Arrange
            string str = "Ананас";
            List<char> expected = new List<char>() { 'А', 'Н', 'С' };
            //Act
            List<char> action = StringCheck.GetLetters(str);
            //Assert
            CollectionAssert.AreEqual(expected, action);
        }
        /// <summary>
        /// дгвба_дгвба
        /// </summary>
        [TestMethod]
        public void StringCheck_дгвба_дгвба_ReturnedАБВГД()
        {
            // Arrange
            string str = "дгвба_дгвба";
            List<char> expected = new List<char>() { 'А', 'Б', 'В', 'Г', 'Д' };
            //Act
            List<char> action = StringCheck.GetLetters(str);
            //Assert
            CollectionAssert.AreEqual(expected, action);
        }

        /// <summary>
        /// 123 @#$%^&*()
        /// </summary>
        [TestMethod]
        public void StringCheck_symbols_ReturnedEmptyString()
        {
            // Arrange
            string str = "123 @#$%^&*()";
            List<char> expected = new List<char>() { };
            //Act
            List<char> action = StringCheck.GetLetters(str);
            //Assert
            CollectionAssert.AreEqual(expected, action);
        }

        /// <summary>
        /// Empty
        /// </summary>
        [TestMethod]
        public void StringCheck_EmptryString_ReturnedEmptyString()
        {
            // Arrange
            string str = "";
            List<char> expected = new List<char>() { };
            //Act
            List<char> action = StringCheck.GetLetters(str);
            //Assert
            CollectionAssert.AreEqual(expected, action);
        }


        [DataTestMethod]
        [DataRow("", new char[]{} )]
        [DataRow("Ананас", new char[] { 'А', 'Н', 'С' })]
        [DataRow("дгвба_дгвба", new char[] { 'А', 'Б', 'В', 'Г', 'Д' })]
        [DataRow("123 @#$%^&*()", new char[] {})]
        [DataRow("BOBA", new char[] { 'A', 'B', 'O' })]

        public void AllTests(string word, char[]expect)
        {
            //Act
            List<char> action = StringCheck.GetLetters(word);
            //Assert
            CollectionAssert.AreEqual(expect.ToList(), action);
        }
    }
}
