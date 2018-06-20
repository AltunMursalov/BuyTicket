using BuyTicket.Interfaces;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace BuyTicket {
    public partial class MainWindow : Window, ITicketBuyView {
        public MainWindow() {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e) {
            var item = sender as Border;
            item.BorderBrush = Brushes.Red;
        }

        public void BindDataContext(ITicketBuyViewModel viewModel) {
            this.DataContext = viewModel;
        }

        public void ShowAlert(string text, string caption) {
            MessageBox.Show(text, caption);
        }

        public MessageBoxResult ConfirmOperation(string text, string caption) {
            return MessageBox.Show(text, caption, MessageBoxButton.YesNo, MessageBoxImage.Question);
        }

        private void HallMap_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }
    }
}