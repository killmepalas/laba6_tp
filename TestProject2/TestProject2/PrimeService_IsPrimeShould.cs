using NUnit.Framework;

namespace TestProject2
{
    public class PrimeService_IsPrimeShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }
    }
}