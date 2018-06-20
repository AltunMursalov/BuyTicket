using BuyTicket.Common;

namespace BuyTicket {
    public class Seat : NotifyableObject {
        public int Row { get; set; }
        public int Col { get; set; }
        private IsBusy isBusy;
        public IsBusy IsBusy { get => isBusy; set { isBusy = value; base.OnChanged(); } }
    }
}