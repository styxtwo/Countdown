using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    public interface IConverter {
        double Convert(TimeSpan timeSpan);
        String Unit();
    }
}
