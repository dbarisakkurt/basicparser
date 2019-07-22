using BasicRecursiveDescentParser;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserTest
{
    [TestFixture]
    public class ParserTests
    {
        [TestCase("abcd")]
        [TestCase("abccd")]
        [TestCase("abccccccd")]
        [TestCase("abccccccccccccccccccccccd")]
        public void Test_Parser(string input)
        {
            Parser p = new Parser(input); 
            p.Parse();
            //no exception expected
        }

        [TestCase("e")]
        [TestCase("")]
        [TestCase("ef")]
        [TestCase("ab")]
        [TestCase("dcba")]
        [TestCase("abc")]
        public void TestParser_InvalidInput_ThrowsException(string input)
        {
            Parser p = new Parser(input);
            Assert.That(() => p.Parse(), Throws.Exception);
        }
    }
}
 