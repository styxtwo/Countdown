using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace CountDown.Domain.Tests {
    [TestClass]
    public class PollerTest {
        private Poller poller;
        public void Setup() {
            poller = new Poller();
        }

        [TestMethod]
        public void PollerCallsAction() {
            Setup();
            bool eventReceived = false;
            poller.Poll += delegate { 
                eventReceived = true; 
            };
            Thread.Sleep(150);
            Assert.IsTrue(eventReceived);
        }

        [TestMethod]
        public void IntervalCanBeSet() {
            Setup();
            bool eventReceived = false;
            poller.Poll += delegate { 
                eventReceived = true; 
            };
            poller.SetInterval(2000);
            Thread.Sleep(150);
            Assert.IsFalse(eventReceived);
        }
    }
}
