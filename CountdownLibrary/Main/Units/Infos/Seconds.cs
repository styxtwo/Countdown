﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    class Seconds : UnitInfo {
        public override double Convert(DateTime start, DateTime end) {
            return (end - start).TotalSeconds;
        }

        public override int Decimals {
            get { return 0; }
        }

        public override string UnitName {
            get { return "Seconds"; }
        }
    }
}
