using System.Windows;
using Autofac;
using BuyTicket.Interfaces;
using BuyTicket.ViewModel;

namespace BuyTicket {
    public partial class App : Application {
        public IContainer Container { get; private set; }

        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            var builder = new ContainerBuilder();
            #region ViewModels
            builder.RegisterType<MainWindowViewModel>().As<ITicketBuyViewModel>();
            #endregion
            #region Views
            builder.RegisterType<MainWindow>().As<ITicketBuyView>();
            #endregion
            Container = builder.Build();
            var viewModel = Container.Resolve<ITicketBuyViewModel>();
            this.MainWindow = viewModel.View as Window;
            this.MainWindow.Show();
        }
    }
}