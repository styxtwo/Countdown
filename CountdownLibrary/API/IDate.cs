﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    public interface IDate {
        DateTime DateTime { get; set; }
        TimeSpan TimeLeft { get; }
        String Name { get; set; }
    }
}
