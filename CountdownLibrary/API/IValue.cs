using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    public interface IValue {
        event Action<IValue> Changed;
        IUnit Unit {get; }
        double Value { get; }
    }
}
