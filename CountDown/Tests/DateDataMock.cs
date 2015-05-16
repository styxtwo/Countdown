using CountDown.Domain.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDown.Domain.Tests {
    class DateDataMock : IDateData{
        public DateTime DateTime {
            get { return new DateTime(2000, 3, 4); }
        }

        public string Name {
            get { return "MockDate"; }
        }
    }
}
