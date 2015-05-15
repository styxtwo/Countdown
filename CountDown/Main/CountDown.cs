using CountDown.Domain.Api;

namespace CountDown.Domain {
    class CountDown : ICountDown {
        private Date date;
        private RemainingTime remainingTime;
        public CountDown(IDateData dateData) {
            date = new Date(dateData);
            remainingTime = new RemainingTime(date);
        }

        public IUnitTime RemainingTime(Unit unit) {
            return remainingTime.InUnit(unit);
        }
        
        public IDate Date {
            get {
                return date; 
            }
        }
    }
}
