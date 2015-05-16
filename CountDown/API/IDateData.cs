using System;

namespace CountDown.Domain.Api {
    public interface IDateData {
        DateTime DateTime { get; }
        String Name { get; }
        Unit MainUnit { get; }
    }
}
