using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Net.Sockets;

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
        }

        private void btn_connectStation_Click(object sender, RoutedEventArgs e)
        {
            //Data Source=Shjn\sqlexpress;Initial Catalog=ITD_SyncMonitor;User ID=sa;password=123456;
            //string severname = txt_StationName.Text.ToString();
            //string connString = "Data Source=" + txt_StationName.Text.ToString() +";Initial Catalog=" + txt_dbStationName.Text.ToString() + ";User ID=" + txt_UserDbStation.Text.ToString() + ";password="+ pas_PasswordStation.Password + ";";
            //SqlConnection conn = new SqlConnection(connString);
            //try
            //{
            //    if (conn.State == ConnectionState.Closed)
            //    {
            //        conn.Open();
            //        MessageBox.Show("a");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Lỗi đăng nhập");
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Mật khẩu hoặc tài khoản không đúng");
            //};
        }

        private void btn_ConnectLane_Click(object sender, RoutedEventArgs e)
        {
            string severname = txt_StationName.Text.ToString();
            string connString = "Data Source=" + txt_LaneName.Text.ToString()+ @"\sqlexpress" + ";Initial Catalog=" + txt_dbLaneName.Text.ToString() + ";User ID=" + txt_UserDbLane.Text.ToString() + ";password=" + pas_PasswordLane.Password + ";";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    MessageBox.Show("Kết nối thành công");
                }
                else
                {
                    MessageBox.Show("Lỗi đăng nhập");
                }
            }
            catch
            {
                MessageBox.Show("Mật khẩu hoặc tài khoản không đúng");
            };
        }
    }
}
