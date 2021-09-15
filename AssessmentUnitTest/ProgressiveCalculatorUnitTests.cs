using Microsoft.VisualStudio.TestTools.UnitTesting;

using PayspaceAssessment.Models.DbModel;
using PayspaceAssessment.Service.TaxCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentUnitTest
{
    [TestClass]
    public class ProgressiveCalculatorUnitTests
    {
        private readonly ITaxCalculator _taxCalculator;
        private List<TblRate> _tblRates;

        public ProgressiveCalculatorUnitTests()
        {
            _tblRates = SeedMockData();
            _taxCalculator = new ProgressiveTaxCalculator(_tblRates);
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void TestProgressiveTax10PercentageRange()
        {
            var annualIncome = 5000.0;

            var result = _taxCalculator.CalcualtionTax(annualIncome);

            Assert.AreEqual(500.0, result);
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void TestProgressiveTax15PercentageRange()
        {
            var annualIncome = 8351.0;

            var result = _taxCalculator.CalcualtionTax(annualIncome);

            Assert.AreEqual(1252.65, result);
        }

        [TestMethod]
        public void TestProgressiveTax25PercentageRange()
        {
            var annualIncome = 33951.00;

            var result = _taxCalculator.CalcualtionTax(annualIncome);

            Assert.AreEqual(8487.75, result);
        }

        [TestMethod]
        public void TestProgressiveTax28PercentageRange()
        {
            var annualIncome = 82251.00;

            var result = _taxCalculator.CalcualtionTax(annualIncome);

            Assert.AreEqual(23030.28, result);
        }

        [TestMethod]
        public void TestProgressiveTax33PercentageRange()
        {
            var annualIncome = 171551.00;

            var result = _taxCalculator.CalcualtionTax(annualIncome);

            Assert.AreEqual(56611.83, result);
        }

        [TestMethod]
        public void TestProgressiveTax35PercentageRange()
        {
            var annualIncome = 372951.00;

            var result = _taxCalculator.CalcualtionTax(annualIncome);

            Assert.AreEqual(130532.85, result);
        }

        private List<TblRate> SeedMockData()
        {
            _tblRates = new List<TblRate>();
            _tblRates.Add(new TblRate { RateId = 1, Rate = 10, FromRate = 0, ToRate = 8350 });
            _tblRates.Add(new TblRate { RateId = 2, Rate = 15, FromRate = 8351, ToRate = 33950 });
            _tblRates.Add(new TblRate { RateId = 3, Rate = 25, FromRate = 33951, ToRate = 82250 });
            _tblRates.Add(new TblRate { RateId = 4, Rate = 28, FromRate = 8225, ToRate = 171550 });
            _tblRates.Add(new TblRate { RateId = 5, Rate = 33, FromRate = 171551, ToRate = 372950 });
            _tblRates.Add(new TblRate { RateId = 6, Rate = 35, FromRate = 372951, ToRate = 999999 });

            return _tblRates;
        }
    }
}
