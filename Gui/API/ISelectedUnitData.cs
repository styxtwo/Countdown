﻿using CountDown.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDown.Gui.API {
    public interface ISelectedUnitData {
        Unit Unit { get; }
    }
}
