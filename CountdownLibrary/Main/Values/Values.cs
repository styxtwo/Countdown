using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CountDownLibrary {
    class Values {
        private IDictionary<UnitType, Value> values = new Dictionary<UnitType, Value>();

        public Values(Date date) {
            AddValue(date, new Seconds());
            AddValue(date, new Minutes());
            AddValue(date, new Days());
            AddValue(date, new Weeks());
        }

        public Value GetValue(UnitType type) {
            Value converter;
            values.TryGetValue(type, out converter);
            if (converter == null) {
                throw (new ArgumentException("No Value available for this unit type. This should not happen."));
            }
            return converter;
        }

        private void AddValue(Date date, Unit unit) {
            Value value = new Value(unit, date);
            values.Add(unit.UnitType, value);
        }
    }
}
