using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    abstract class UnitInfo : IUnitInfo{
        public abstract int Decimals { get; }
        public abstract string UnitName { get; }
        public abstract double Convert(DateTime start, DateTime end);
    }
}
