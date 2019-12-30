using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SyncMonitor.ViewModel;
using System.Windows.Input;
using SyncMonitor.Model;
using System.Collections.ObjectModel;

namespace SyncMonitor.ViewModel
{
    public class MainViewModel: BaseViewModel
    {
        public ICommand add { get; set; }
        private ObservableCollection<ServerDB> sever;
        public ObservableCollection<ServerDB> Lanelist { get => sever; set { sever = value; OnPropertyChanged(); } }

        public MainViewModel()
        {
            ServerDB Lanelist = new ObservableCollection<>(sever);

        }
    }
}
