using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountDownLibrary {
    public interface IUnitTime {
        event Action<IUnitTime> Changed;
        double Value { get;  }
        IUnitInfo Info { get;  }
    }
}
