using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BuyTicket.Common {
    public class NotifyableObject : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnChanged([CallerMemberName] string name = "") {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}