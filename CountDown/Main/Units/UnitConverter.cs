using CountDown.Domain.Api;
using System;

namespace CountDown.Domain {
    abstract class UnitConverter : IUnitInfo {
        public abstract int Decimals { get; }
        public abstract string UnitName { get; }
        public abstract double Convert(DateTime start, DateTime end);
    }
}
