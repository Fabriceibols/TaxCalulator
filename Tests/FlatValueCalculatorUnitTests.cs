using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayspaceAssessment.Service.TaxCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    class FlatValueCalculatorUnitTests
    {
        private readonly ITaxCalculator _taxCalculator;

        public FlatValueCalculatorUnitTests()
        {
            _taxCalculator = new FlatValueTaxCalculator();
        }


        [TestMethod]
        public void TestFlatValueTaxRetuns10000()
        {
            var annualIncome = 210000.0;

            var result = _taxCalculator.CalcualtionTax(annualIncome);

            Assert.AreEqual(10000, result);
        }

        [TestMethod]
        public void TestFlatValueTaxMultipleFivePercentage()
        {
            var annualIncome = 21000.0;

            var result = _taxCalculator.CalcualtionTax(annualIncome);

            Assert.AreEqual(1050, result);
        }
    }
}
