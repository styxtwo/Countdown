using System;

namespace CountDown.Domain.Api {
    public interface IUnitTime {
        event Action<IUnitTime> ValueChanged;
        double Value { get;  }
        IUnitInfo Info { get;  }
    }
}
