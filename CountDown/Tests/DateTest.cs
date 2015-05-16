using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CountDown.Domain.Tests {
    [TestClass]
    public class DateTest {
        private Date date;
        public void Setup() {
            date = new Date(new DateDataMock());
        }
        [TestMethod]
        public void DateChangesOnSet() {
            Setup();
            bool dateChanged = false;
            date.DateChanged += delegate { 
                dateChanged = true; 
            };

            date.DateTime = new DateTime(1990, 1, 1);

            Assert.AreEqual(new DateTime(1990, 1, 1), date.DateTime);
            Assert.IsTrue(dateChanged);
        }

        [TestMethod]
        public void NameChangesOnSet() {
            Setup();
            bool nameChanged = false;
            date.NameChanged += delegate { 
                nameChanged = true; 
            };

            date.Name = "New Name";

            Assert.AreEqual("New Name", date.Name);
            Assert.IsTrue(nameChanged);
        }
    }
}
