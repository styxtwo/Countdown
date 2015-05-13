using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountDown.Domain.Api {
    public interface IUnitTime {
        event Action<IUnitTime> ValueChanged;
        double Value { get;  }
        IUnitInfo Info { get;  }
    }
}
