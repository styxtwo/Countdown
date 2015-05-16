using CountDown.Domain;
using CountDown.Domain.Api;
using System;
using System.Collections.Generic;
using Utilities.Extensions;

namespace CountDown.Gui {
    public class DisplayDataList {
        public event Action SelectedDataChangedEvent;
        private IList<DisplayData> data = new List<DisplayData>();
        private int index;
        private DisplayData selectedData;
        private IDate date;
        public DisplayDataList(ICountDown countdown, Unit selectedUnit) {
            foreach (Unit unit in Enum.GetValues(typeof(Unit))) {
                data.Add(new DisplayData(countdown, unit));
                if (unit == selectedUnit) {
                    index = data.Count - 1;
                }
            }
            this.date = countdown.Date;
            SetSelectedData(index);
        }

        public DisplayData Selected() {
            return selectedData;
        }

        public void Next() {
            index++;
            if (index >= data.Count) {
                index = 0;
            }
            SetSelectedData(index);
        }

        public void Previous() {
            index--;
            if (index < 0) {
                index = data.Count - 1;
            }
            SetSelectedData(index);
        }

        public void Random() {
            int prevIndex = index;
            do {
                Random random = new Random();
                index = random.Next(data.Count);
            } while (prevIndex == index);
            SetSelectedData(index);
        }

        private void SetSelectedData(int index) {
            if (selectedData != null) {
                selectedData.DataChangedEvent -= DataChanged;
            }
            selectedData = data[index];
            selectedData.DataChangedEvent += DataChanged;
            SelectedDataChangedEvent.NullSafeInvoke();
            date.MainUnit = selectedData.Unit;
        }

        private void DataChanged() {
            SelectedDataChangedEvent.NullSafeInvoke();
        }

        internal void Dispose() {
            SelectedDataChangedEvent = null;
            selectedData.DataChangedEvent -= SelectedDataChangedEvent;
        }
    }
}
