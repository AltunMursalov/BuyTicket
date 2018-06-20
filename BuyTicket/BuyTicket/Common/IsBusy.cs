using BuyTicket.Common;

namespace BuyTicket {
    public class IsBusy : NotifyableObject {
        private bool isEmpty;
        public bool IsEmpty { get => isEmpty; set { isEmpty = value; base.OnChanged(); } }

        public IsBusy(bool value) {
            IsEmpty = value;
        }
    }
}