using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    public interface ICountDown {
        IDate Date { get; }
        IUnitTime RemainingTime(Unit unit);
    }
}
