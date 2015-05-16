using CountDown.Domain.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDown.Domain.Tests {
    [TestClass]
    public class WeekDaysTest {

        private UnitConverter converter;
        private DateTime start;
        private DateTime end;
        public void Setup() {
            converter = new WeekDays();
        }

        [TestMethod]
        public void SaturdayToSunday() {
            Setup();
            start = new DateTime(2015, 5, 16);
            end = new DateTime(2015, 5, 24);
            double amount = converter.Convert(start, end);
            Assert.AreEqual(5, amount);
        }

        [TestMethod]
        public void SaturdayToSaturday() {
            Setup();
            start = new DateTime(2015, 5, 16);
            end = new DateTime(2015, 5, 23);
            double amount = converter.Convert(start, end);
            Assert.AreEqual(5, amount);
        }

        [TestMethod]
        public void MondayToSaturday() {
            Setup();
            start = new DateTime(2015, 5, 18);
            end = new DateTime(2015, 5, 23);
            double amount = converter.Convert(start, end);
            Assert.AreEqual(5, amount);
        }

        [TestMethod]
        public void MondayToFriday() {
            Setup();
            start = new DateTime(2015, 5, 18);
            end = new DateTime(2015, 5, 22);
            double amount = converter.Convert(start, end);
            Assert.AreEqual(5, amount);
        }

        [TestMethod]
        public void TuesdayToFriday() {
            Setup();
            start = new DateTime(2015, 5, 19);
            end = new DateTime(2015, 5, 22);
            double amount = converter.Convert(start, end);
            Assert.AreEqual(4, amount);
        }

        [TestMethod]
        public void TuesdayToSunday() {
            Setup();
            start = new DateTime(2015, 5, 19);
            end = new DateTime(2015, 5, 24);
            double amount = converter.Convert(start, end);
            Assert.AreEqual(4, amount);
        }

        [TestMethod]
        public void SundayToSunday() {
            Setup();
            start = new DateTime(2015, 5, 17);
            end = new DateTime(2015, 5, 24);
            double amount = converter.Convert(start, end);
            Assert.AreEqual(5, amount);
        }

        [TestMethod]
        public void SundayToSaturday() {
            Setup();
            start = new DateTime(2015, 5, 17);
            end = new DateTime(2015, 5, 23);
            double amount = converter.Convert(start, end);
            Assert.AreEqual(5, amount);
        }

        [TestMethod]
        public void MondayToWensday() {
            Setup();
            start = new DateTime(2015, 5, 18);
            end = new DateTime(2015, 5, 20);
            double amount = converter.Convert(start, end);
            Assert.AreEqual(3, amount);
        }
    }
}
