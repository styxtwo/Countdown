using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountDown.Domain.Api;

namespace CountDown.Domain {
    public class CountDownFactory {
        public static ICountDown Create(IDateData dateData) {
            return new CountDown(dateData);
        }
    }
}
