﻿using CountDown.Domain;
using CountDown.Domain.Api;
using System;
using System.Collections.Generic;
using Utilities.Extensions;

namespace CountDown.Gui {
    public class DisplayDataList {
        public event Action CurrentDataChangedEvent;
        private IList<DisplayData> data = new List<DisplayData>();
        private int index;
        private DisplayData currentData;
        private IDate date;
        public DisplayDataList(ICountDown countdown, Unit selectedUnit) {
            foreach (Unit unit in Enum.GetValues(typeof(Unit))) {
                data.Add(new DisplayData(countdown, unit));
                if (unit == selectedUnit) {
                    index = data.Count - 1;
                }
            }
            this.date = countdown.Date;
            SetCurrentData();
        }

        public DisplayData Current() {
            return currentData;
        }

        public void Next() {
            index++;
            if (index >= data.Count) {
                index = 0;
            }
            SetCurrentData();
        }

        public void Previous() {
            index--;
            if (index < 0) {
                index = data.Count - 1;
            }
            SetCurrentData();
        }

        public void Random() {
            int prevIndex = index;
            do {
                Random random = new Random();
                index = random.Next(data.Count);
            } while (prevIndex == index);
            SetCurrentData();
        }

        private void SetCurrentData() {
            if (currentData != null) {
                currentData.DataChangedEvent -= DataChanged;
            }
            currentData = data[index];
            currentData.DataChangedEvent += DataChanged;
            CurrentDataChangedEvent.NullSafeInvoke();
        }

        public void SetCurrentToSelected() {
            foreach(DisplayData displayData in data){
                if (displayData.IsSelected()) {
                    index = data.IndexOf(displayData);
                    SetCurrentData();
                }
            }
        }

        private void DataChanged() {
            CurrentDataChangedEvent.NullSafeInvoke();
        }

        internal void Dispose() {
            CurrentDataChangedEvent = null;
            currentData.DataChangedEvent -= CurrentDataChangedEvent;
        }
    }
}
