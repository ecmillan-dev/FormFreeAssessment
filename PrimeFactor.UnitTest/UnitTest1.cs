using NUnit.Framework;
using PrimeFactor.App;
using PrimeFactor.App.Interface;
using PrimeFactor.App.Service;

namespace PrimeFactor.UnitTest
{
    public class Tests
    {
        private static IPrimeFactor _primeFactorService;
        private static IFileReader _fileService;
        [SetUp]
        public void Setup()
        {
            // init the services
            _primeFactorService = new PrimeFactorService();
            _fileService = new FileReaderService();
        }

        [Test]
        public void TestPrimeFactors()
        {
            Assert.AreEqual("2,2,2", _primeFactorService.GetPrimeFactorList(8));
            Assert.AreEqual("7", _primeFactorService.GetPrimeFactorList(7));
            Assert.AreEqual("3,3,5,7", _primeFactorService.GetPrimeFactorList(315));
            Assert.AreEqual("2,2,5,5", _primeFactorService.GetPrimeFactorList(100));
        }

        /// <summary>
        /// test that these inputs will throw an exception of InvalidIntegerInputException
        /// </summary>
        [Test]
        public void TestPrimeFactorsInvalid()
        {
            Assert.Catch<InvalidIntegerInputException>(delegate { _primeFactorService.GetPrimeFactorList(1); });
            Assert.Catch<InvalidIntegerInputException>(delegate { _primeFactorService.GetPrimeFactorList(0); });
            Assert.Catch<InvalidIntegerInputException>(delegate { _primeFactorService.GetPrimeFactorList(-5); });

        }
    }
}