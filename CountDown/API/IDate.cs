using System;

namespace CountDown.Domain.Api {
    public interface IDate {
        event Action NameChanged;
        event Action DateChanged;
        event Action MainUnitChanged;
        DateTime DateTime { get; set; }
        String Name { get; set; }
        Unit MainUnit { get; set; }
    }
}
