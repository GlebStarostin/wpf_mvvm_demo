using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVMWpfApplication.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {

        public ObservableCollection<InfoPanelViewModel> InfoPanels { get; } = new ObservableCollection<InfoPanelViewModel>();

        public MainViewModel()
        {
            this.InfoPanels = new ObservableCollection<InfoPanelViewModel>()
            {
                new InfoPanelViewModel(header: "header1") { IsVisible = true },
                new InfoPanelViewModel(header: "header2"),
                new InfoPanelViewModel(header: "header3"),
                new InfoPanelViewModel(header: "header4"),
            };
        }

    }
}
