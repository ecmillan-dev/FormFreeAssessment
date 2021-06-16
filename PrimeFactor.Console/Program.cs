using PrimeFactor.App.Interface;
using PrimeFactor.App.Service;
using System;

namespace PrimeFactor.App
{
    class Program
    {
        private static IPrimeFactor _primeFactorService;
        private static IFileReader _fileService;
        static void Main(string[] args)
        {
            // init the services
            _primeFactorService = new PrimeFactorService();
            _fileService = new FileReaderService();
            try
            {
                var lines = _fileService.GetIntegerLinesFromInputFile(@"C:\Users\Chris\source\repos\ecmillan-dev\FormFreeAssessment\PrimeFactor.Console\input1.txt");
                foreach (var line in lines)
                {
                    Console.WriteLine(line + " factors - " + _primeFactorService.GetPrimeFactorList(line));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                // continue
            }

            
        }
    }
}
