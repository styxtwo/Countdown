using CountDown.Domain;
using CountDown.Domain.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDown.Gui {
    public class DisplayDataList {
        private IList<DisplayData> data = new List<DisplayData>();
        private int index;
        public DisplayDataList(ICountDown countdown) {
            foreach (Unit unit in Enum.GetValues(typeof(Unit))) {
                data.Add(new DisplayData(countdown, unit));
                if (unit == Unit.Days) {
                    index = data.Count - 1;
                }
            }
        }

        public DisplayData Current() {
            return data[index];
        }

        public DisplayData Next() {
            index++;
            if (index >= data.Count) {
                index = 0;
            }
            return data[index];
        }

        public DisplayData Previous() {
            index--;
            if (index < 0) {
                index = data.Count - 1;
            }
            return data[index];
        }

        public DisplayData Random() {
            int prevIndex = index;
            do {
                Random random = new Random();
                index = random.Next(data.Count);
            } while (prevIndex == index);
            return data[index];
        }
    }
}
