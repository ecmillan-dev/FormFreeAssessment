using PrimeFactor.App.Interface;
using PrimeFactor.App.Service;
using System;

namespace PrimeFactor.App
{
    class Program
    {
        private static IPrimeFactor _primeFactorService;
        static void Main(string[] args)
        {
            // init the service
            _primeFactorService = new PrimeFactorService();

            Console.WriteLine("Hello World!");
            Console.WriteLine(_primeFactorService.GetPrimeFactorList(64));
        }
    }
}
