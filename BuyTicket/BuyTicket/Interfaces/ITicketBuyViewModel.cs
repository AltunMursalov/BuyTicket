using System.Windows.Input;

namespace BuyTicket.Interfaces {
    public interface ITicketBuyViewModel {
        ITicketBuyView View { get; }
        ICommand Reservation { get; }
    }
}