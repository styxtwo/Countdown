using System;

namespace CountDown.Domain.Api {
    public interface IDate {
        event Action NameChanged;
        event Action DateChanged;
        DateTime DateTime { get; set; }
        String Name { get; set; }
    }
}
