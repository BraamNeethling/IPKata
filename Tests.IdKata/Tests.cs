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
    public class Tests
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

        private static IPKata IpKataCreator()
        {
            return new IPKata();
        }
    }
}
