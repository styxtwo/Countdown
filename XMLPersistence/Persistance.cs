using CountDown.Domain.Api;

namespace XMLPersistence
{
    public class Persistance
    {
        private DateData data;
        private ICountDown countDown;
        public Persistance() {
            data = new DateData();
        }

        public void UpdateOnChange(ICountDown countDown) {
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


        public IDateData Data {
            get {
                return data;
            }
        }

        public void Dispose() {
            countDown.Date.DateChanged -= DateChanged;
            countDown.Date.NameChanged -= NameChanged; 
        }
    }
}
