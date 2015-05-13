using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDown.Domain.Api {
    public interface IDateData {
        DateTime DateTime { get; }
        String Name { get; }
    }
}
