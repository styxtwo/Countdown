using CountDown.Domain.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDown.Domain {
    abstract class UnitConverter : IUnitInfo {
        public abstract int Decimals { get; }
        public abstract string UnitName { get; }
        public abstract double Convert(DateTime start, DateTime end);
    }
}
