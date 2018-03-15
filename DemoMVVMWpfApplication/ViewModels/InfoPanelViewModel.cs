using DemoMVVMWpfApplication.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVMWpfApplication.ViewModels
{
    internal class InfoPanelViewModel : BaseViewModel
    {

        public InfoPanelViewModel(string header)
        {
            this.Header = header;

            this.Infos = new ObservableCollection<InfoModel>()
            {
                new InfoModel(parameterName: "parameter", value: "value"),
                new InfoModel(parameterName: "parameter", value: "value"),
                new InfoModel(parameterName: "parameter", value: "value"),
                new InfoModel(parameterName: "parameter", value: "value")
            };
        }

        private string _header;
        public string Header
        {
            get { return this._header; }
            set
            {
                this._header = value;
                this.RaisePropertyChanged(nameof(this.Header));
            }
        }

        public ObservableCollection<InfoModel> Infos { get; } = new ObservableCollection<InfoModel>();

        private bool _isVisible = false;
        public bool IsVisible
        {
            get { return this._isVisible; }
            set
            {
                this._isVisible = value;
                this.RaisePropertyChanged(nameof(this.IsVisible));
            }
        }

    }
}
