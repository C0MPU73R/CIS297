using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {

            char[] characters = new char[5]; //original
            characters[0] = 'a';
            characters[1] = 'b';
            characters[2] = 'c';
            characters[3] = 'd';
            characters[4] = 'e';

            char[] expected = new char[5]; //expected
            characters[0] = 'e';
            characters[1] = 'd';
            characters[2] = 'c';
            characters[3] = 'b';
            characters[4] = 'a';

            reverseClass r;
            r = new reverseClass();
            char[] result = r.ReverseCharacters(characters);
            Assert.AreEqual(result, expected);

                







        }
    }
}
