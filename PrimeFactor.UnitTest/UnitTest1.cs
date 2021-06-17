using NUnit.Framework;
using PrimeFactor.App;
using PrimeFactor.App.Interface;
using PrimeFactor.App.Service;
using System.IO;
using System.Linq;

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

        [Test]
        public void TestFileInputReading()
        {
            var lines = _fileService.GetIntegerLinesFromInputFile(@"input1.txt").ToArray();
            // compare each line with what we know should be there
            /*
             * 315
                26
                5435
                999
                78
                7
             */
            Assert.AreEqual(315, lines[0]);
            Assert.AreEqual(26, lines[1]);
            Assert.AreEqual(5435, lines[2]);
            Assert.AreEqual(999, lines[3]);
            Assert.AreEqual(78, lines[4]);
            Assert.AreEqual(7, lines[5]);

        }

        /// <summary>
        /// tests that when a file has invalid inputs (meaning non integers and/or integers less than 2
        /// </summary>
        [Test]
        public void TestInvalidFileData()
        {
            Assert.Catch<InvalidIntegerInputException>(delegate { _fileService.GetIntegerLinesFromInputFile(@"invalidinputline.txt"); });
        }

        /// <summary>
        /// test that an invalid file path throws correctly
        /// </summary>
        [Test]
        public void TestFilePathNotFound()
        {
            Assert.Catch<IOException>(delegate { _fileService.GetIntegerLinesFromInputFile(@"‪C:\Users\ChrisTest\Downloads\mailFilters.txt"); });
        }
    }
}