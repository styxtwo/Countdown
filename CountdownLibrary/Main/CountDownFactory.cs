using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    public class CountDownFactory {
        public static ICountDown Create() {
            return new CountDown();
        }
    }
}
