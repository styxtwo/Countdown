using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CountDownLibrary {
    class CountDown : ICountDown {
        private IDictionary<ConverterType, Converter> converters = new Dictionary<ConverterType, Converter>();
        public IDate Date { get; private set; }
        public CountDown() {
            Date = new Date();
            converters.Add(ConverterType.Minutes, new Minutes(Date));
            converters.Add(ConverterType.Weeks, new Weeks(Date));
        }

        public void AddObserver(ConverterType type, Action<IConverter> action){
            Converter converter = GetConverter(type);
            if(converter != null) {
                converter.Changed += action;
            }
        }

        public void RemoveObserver(ConverterType type, Action<IConverter> action) {
            Converter converter = GetConverter(type);
            if (converter != null) {
                converter.Changed -= action;
            }
        }

        private Converter GetConverter(ConverterType type) {
            Converter converter;
            converters.TryGetValue(type, out converter);
            return converter;
        }
    }
}
