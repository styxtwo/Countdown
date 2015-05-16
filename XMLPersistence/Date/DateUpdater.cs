using CountDown.Domain.API;

namespace XMLPersistence
{
    class DateUpdater
    {
        private DateData data;
        private ICountDown countDown;
        public DateUpdater(ICountDown countDown, DateData data) {
            this.data = data;
            this.countDown = countDown;
            countDown.Date.DateChanged += DateChanged;
            countDown.Date.NameChanged += NameChanged; 
        }

        private void NameChanged() {
            data.Name = countDown.Date.Name;
        }

        private void DateChanged() {
            data.DateTime = countDown.Date.DateTime;
        }

        public void Dispose() {
            countDown.Date.DateChanged -= DateChanged;
            countDown.Date.NameChanged -= NameChanged; 
        }
    }
}
