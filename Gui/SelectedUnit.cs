using CountDown.Domain;
using CountDown.Gui.API;
using System;
using Utilities.Extensions;

namespace CountDown.Gui {
    public class SelectedUnit {
        private Unit unit;
        public event Action Changed;
        public SelectedUnit(ISelectedUnitData unit) {
            this.unit = unit.Unit;
        }

        public Unit Unit { 
            get {
                return unit;
            }
            set {
                unit = value;
                Changed.NullSafeInvoke();
            }
        }
    }
}
