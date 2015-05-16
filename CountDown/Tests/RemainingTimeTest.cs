using CountDown.Domain.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDown.Domain.Tests {
    [TestClass]
    public class RemainingTimeTest {

        private RemainingTime time;
        public void Setup() {
            time = new RemainingTime(new Date(new DateDataMock()));
        }

        [TestMethod]
        public void TimeInDaysReturnsZero() {
            Setup();
            IUnitTime unitTime = time.InUnit(Unit.Days);
            Assert.AreEqual(0, unitTime.Value);
        }
    }
}
