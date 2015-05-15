using CountDown.Domain.Api;

namespace CountDown.Domain {
    public class CountDownFactory {
        public static ICountDown Create(IDateData dateData) {
            return new CountDown(dateData);
        }
    }
}
