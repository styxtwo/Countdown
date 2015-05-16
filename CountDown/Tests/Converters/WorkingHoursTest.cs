using CountDown.Domain.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDown.Domain.Tests {
    [TestClass]
    public class WorkingHoursTest {

        private UnitConverter converter;
        private DateTime start;
        private DateTime end;
        public void Setup() {
            converter = new WorkingHours();
            start = new DateTime(1990, 2, 8);
            end = new DateTime(1992, 3, 1);
        }

        [TestMethod]
        public void ConvertReturnsCorrectAmount() {
            Setup();
            double amount = converter.Convert(start, end);
            Assert.AreEqual(4296, amount);
        }
    }
}
