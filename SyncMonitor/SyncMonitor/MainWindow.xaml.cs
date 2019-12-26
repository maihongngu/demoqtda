
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ITD_SyncMonitor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<connectchecker> list = new List<connectchecker>();


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
        private void ckb_config_Click(object sender, RoutedEventArgs e)
        {
            if (ckb_config.IsChecked == false)
            {
                Gb_Lane.IsEnabled = false;
                Gb_Schedules.IsEnabled = false;
                Gb_Station.IsEnabled = false;

                ckb_config.IsEnabled = true;
                btn_add.IsEnabled = false;
                btn_update.IsEnabled = false;
                btn_remove.IsEnabled = false;
            }
            else
            {
                Gb_Lane.IsEnabled = true;
                Gb_Schedules.IsEnabled = true;
                Gb_Station.IsEnabled = true;
                ckb_config.IsEnabled = true;
                btn_add.IsEnabled = true;
                btn_update.IsEnabled = true;
                btn_remove.IsEnabled = true;
            }
        }

        public class connectchecker
        {
            public string name { get; set; }
            public string IpAddress { get; set; }
            public string LanetoServerState { get; set; }
            public string ServerToLaneState { get; set; }
            public string OnlineState { get; set; }
            public string LastActiveDate { get; set; }
            public string LastOnlineDate { get; set; }
        }

        private void txt_StationIP_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //if (!char.IsDigit(e.Text, e.Text.Length - 1))
            //    e.Handled = true;
        }
        private void txt_LaneIP_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //if (!char.IsDigit(e.Text, e.Text.Length - 1))
            //    e.Handled = true;
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_LaneIP.Text.ToString() == string.Empty || txt_StationIP.Text.ToString() == string.Empty)
                {
                    MessageBox.Show("Cant not leave IP text empty", "Warning");
                }
                else
                {
                    List<connectchecker> list = new List<connectchecker>();
                    list.Add(new connectchecker() { name = txt_Lane.Text, IpAddress = txt_LaneIP.Text, LanetoServerState = "", ServerToLaneState = "", LastActiveDate = "", LastOnlineDate = "", OnlineState = "" });
                    lsv_LaneList.Items.Add(list);
                }
            }
            catch
            {
                MessageBox.Show("The connect has been crash");
            }
        }

        private void btn_connectStation_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_dbStationName.Text.ToString() == String.Empty || txt_PasswordStation.ToString() == String.Empty || txt_UserDbStation.Text.ToString() == String.Empty)
                {
                    MessageBox.Show("Check your info before connect", "Warnning");
                }
            }
            catch
            {
                MessageBox.Show("Something was wrong");
            }
        }

        private void btn_ConnectLane_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_dbStationName.Text.ToString() == String.Empty || txt_PasswordStation.ToString() == String.Empty || txt_UserDbStation.Text.ToString() == String.Empty)
                {
                    MessageBox.Show("Check your info before connect", "Warnning");
                }
            }
            catch
            {
                MessageBox.Show("Something was wrong");
            }
        }
    }
}
