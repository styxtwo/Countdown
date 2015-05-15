
namespace CountDown.Domain.Api {
    public interface ICountDown {
        IDate Date { get; }
        IUnitTime RemainingTime(Unit unit);
    }
}
