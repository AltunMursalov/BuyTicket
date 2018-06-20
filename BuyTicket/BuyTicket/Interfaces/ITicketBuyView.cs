using System.Windows;

namespace BuyTicket.Interfaces {
    public interface ITicketBuyView {
        void BindDataContext(ITicketBuyViewModel viewModel);
        void ShowAlert(string text, string caption);
        MessageBoxResult ConfirmOperation(string text, string caption);
    }
}