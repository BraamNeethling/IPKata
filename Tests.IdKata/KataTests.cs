using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Katas;
using NUnit.Framework;

namespace Tests.IdKata
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void GivenValidSimpleIP_ShouldReturnTrue()
        {
            //Arrange
            var ip = "1.1.1.1";
            var ipKata = IpKataCreator();
            //Act
            var validateIpv4Address = ipKata.ValidateIpv4Address(ip);
            //Assert
            Assert.AreEqual(validateIpv4Address, true);
            
        }

        [Test]
        public void GivenIPEndsWith0_ShouldReturnFalse()
        {
            //Arrange
            const string ip = "1.1.1.0";
            var ipKata = IpKataCreator();
            //Act
            var validateIpv4Address = ipKata.ValidateIpv4Address(ip);
            //Assert
            Assert.AreEqual(validateIpv4Address, false);

        }

        [Test]
        public void GivenIPEndsWith255_ShouldReturnFalse()
        {
            //Arrange
            const string ip = "255.255.255.255";
            var ipKata = IpKataCreator();
            //Act
            var validateIpv4Address = ipKata.ValidateIpv4Address(ip);
            //Assert
            Assert.AreEqual(validateIpv4Address, false);

        }

        [Test]
        public void GivenIPHasLessThan4Blocks_ShouldReturnFalse()
        {
            //Arrange
            const string ip = "10.0.1";
            var ipKata = IpKataCreator();
            //Act
            var validateIpv4Address = ipKata.ValidateIpv4Address(ip);
            //Assert
            Assert.AreEqual(validateIpv4Address, false);
        }

        [Test]
        public void GivenIPHasLessThan2Blocks_ShouldReturnFalse()
        {
            //Arrange
            const string ip = "10.1";
            var ipKata = IpKataCreator();
            //Act
            var validateIpv4Address = ipKata.ValidateIpv4Address(ip);
            //Assert
            Assert.AreEqual(validateIpv4Address, false);
        }

        [TestCase("1.1.1.1", true)]
        [TestCase("192.168.1.1", true)]
        [TestCase("10.0.0.1", true)]
        [TestCase("127.0.0.1", true)]
        [TestCase("0.0.0.0", false)]
        [TestCase("255.255.255.255", false)]
        [TestCase("1.1.1.0", false)]
        [TestCase("10.0.1", false)]
        public void GivenAllTestCases_ShouldReturnResult(string ipAddress, bool result)
        {
            //Arrange
            var ipKata = IpKataCreator();
            //Act
            var validateIpv4Address = ipKata.ValidateIpv4Address(ipAddress);
            //Assert
            Assert.AreEqual(validateIpv4Address, result);
        }

        private static Kata IpKataCreator()
        {
            return new Kata();
        }
    }

    [TestFixture]
    public class BalancedBracketsTests
    {
        [Test]
        public void GivenEmpty_ReturnsEmptyString()
        {
            //arrange
            var balancedBracketsKata = BalancedBracketsCreator();
            //act
            var validateBrackets = balancedBracketsKata.ValidateBrackets("");
            //assert
            Assert.AreEqual(validateBrackets, "");

        }

        [Test]
        public void GivenSquareBrackets_ReturnsOk()
        {
            //arrange
            var balancedBracketsKata = BalancedBracketsCreator();
            //act
            var validateBrackets = balancedBracketsKata.ValidateBrackets("[]");
            //assert
            Assert.AreEqual(validateBrackets, "Ok");

        }

        [Test]
        public void GivenDoubleSquareBrackets_ReturnsOk()
        {
            //arrange
            var balancedBracketsKata = BalancedBracketsCreator();
            //act
            var validateBrackets = balancedBracketsKata.ValidateBrackets("[][]");
            //assert
            Assert.AreEqual(validateBrackets, "Ok");

        }

        [Test]
        public void GivenDoubleSquareBracketsInsideOuterBrackets_ReturnsOk()
        {
            //arrange
            var balancedBracketsKata = BalancedBracketsCreator();
            //act
            var validateBrackets = balancedBracketsKata.ValidateBrackets("[[]]");
            //assert
            Assert.AreEqual(validateBrackets, "Ok");

        }

        [Test]
        public void GivenDoubleDoubleSquareBracketsInsideOuterBrackets_ReturnsOk()
        {
            //arrange
            var balancedBracketsKata = BalancedBracketsCreator();
            //act
            var validateBrackets = balancedBracketsKata.ValidateBrackets("[[[][]]]");
            //assert
            Assert.AreEqual(validateBrackets, "Ok");

        }

        [Test]
        public void GivenSetOfUnbalancedBrackets_ReturnsFalse()
        {
            //arrange
            var balancedBracketsKata = BalancedBracketsCreator();
            //act
            var validateBrackets = balancedBracketsKata.ValidateBrackets("][");
            //assert
            Assert.AreEqual(validateBrackets, "Fail");

        }

        [Test]
        public void GivenAdditionalSetOfUnbalancedBrackets_ReturnsFalse()
        {
            //arrange
            var balancedBracketsKata = BalancedBracketsCreator();
            //act
            var validateBrackets = balancedBracketsKata.ValidateBrackets("][][");
            //assert
            Assert.AreEqual(validateBrackets, "Fail");

        }

        [Test]
        public void GivenAdditionalSetOfUnbalancedBracketsAtEnd_ReturnsFalse()
        {
            //arrange
            var balancedBracketsKata = BalancedBracketsCreator();
            //act
            var validateBrackets = balancedBracketsKata.ValidateBrackets("[][]][");
            //assert
            Assert.AreEqual(validateBrackets, "Fail");

        }

        private static BalancedBrackets BalancedBracketsCreator()
        {
            return new BalancedBrackets();
        }
    }

    [TestFixture]
    public class LastSundayOfEachMonthTests
    {
        [Test]
        public void GivenYear_ShouldReturnFirstSunday()
        {
            //arrange
            var creator = LastSundayCreator();
            //act
            var sundays = creator.LastSundayOfEachMonth(2013);
            //assert
            Assert.AreEqual(sundays.First(),new DateTime(2013 - 01 - 27));
        }

        private static LastSunday LastSundayCreator()
        {
            return new LastSunday();
        }
    }
}
