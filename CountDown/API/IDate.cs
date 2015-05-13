﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDown.Domain.Api {
    public interface IDate {
        event Action NameChanged;
        event Action DateChanged;
        DateTime DateTime { get; set; }
        String Name { get; set; }
    }
}