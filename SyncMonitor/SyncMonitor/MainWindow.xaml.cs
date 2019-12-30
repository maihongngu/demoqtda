using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.IO;
using System;
using System.Configuration;
using System.Net.NetworkInformation;
using Xamarin.Forms.PlatformConfiguration;
using Microsoft.SqlServer.Dac.Compare;

namespace ITD_SyncMonitor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        
        IPEndPoint IpStation;
        Socket Lane;
        string LaneDB;
        string StationDB;
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
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

        public void LoadData()
        {
            SqlConnection conn = new SqlConnection(LaneDB);
            if (conn.State == ConnectionState.Open)
            {
                string cs = ConfigurationManager.ConnectionStrings[LaneDB].ConnectionString;
                using (conn = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("LS_Lane", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using(SqlDataAdapter SDA = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        SDA.Fill(dt);
                        
                    }
                }
            }
        }
        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(LaneDB);
                if(conn.State == ConnectionState.Open)
                {
                    string cs = ConfigurationManager.ConnectionStrings[LaneDB].ConnectionString;
                    using (conn = new SqlConnection(cs))
                    {
                        
                        SqlCommand cmd = new SqlCommand("LS_Lane",conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        DateTime now = DateTime.MinValue;
                        cmd.Parameters.AddWithValue("@LaneCode",txt_LaneCode.Text.ToString());
                        cmd.Parameters.AddWithValue("@Name", txt_dbLaneName.Text.ToString());
                        cmd.Parameters.AddWithValue("@StationCode", txt_StationCode.Text.ToString());
                        cmd.Parameters.AddWithValue("@IpAddress", txt_LaneIP.Text.ToString());
                        cmd.Parameters.AddWithValue("@LastTimeOnline", now.ToString());
                        cmd.Parameters.AddWithValue("@IsUsed", "True");
                        LoadData();
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa kết nối Database");
                }
                
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        
        private void btn_connectStation_Click(object sender, RoutedEventArgs e)
        {
            //10.0.3.239
            //try
            //{
            //    Ping p = new Ping();
            //    PingReply r;
            //    string s;
            //    s = txt_StationIP.Text.ToString();
            //    r = p.Send(s);

            //    if (r.Status == IPStatus.Success)
            //    {
            //        IpStation = new IPEndPoint(IPAddress.Parse(txt_StationIP.Text.ToString()),9999);
            //        Lane = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            //        MessageBox.Show("Ping to " + s.ToString() + "[" + r.Address.ToString() + "]" + " Successful"
            //           + " Response delay = " + r.RoundtripTime.ToString() + " ms" + "\n");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Không thể kết nối");
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Ip không chính xác");
            //}

            //Data Source = Shjn\sqlexpress; Initial Catalog = ITD_SyncMonitor; User ID = sa; password = 123456;
            //string severname = txt_StationName.Text.ToString();
            StationDB = "Data Source=" + txt_StationIP.Text.ToString() + ";Initial Catalog=" + txt_dbStationName.Text.ToString() + ";User ID=" + txt_UserDbStation.Text.ToString() + ";password=" + pas_PasswordStation.Password + ";";
            SqlConnection conn = new SqlConnection(StationDB);
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

        private void btn_ConnectLane_Click(object sender, RoutedEventArgs e)
        {
            LaneDB = "Data Source=" + txt_LaneName.Text.ToString()+ @"\sqlexpress" + ";Initial Catalog=" + txt_dbLaneName.Text.ToString() + ";User ID=" + txt_UserDbLane.Text.ToString() + ";password=" + pas_PasswordLane.Password + ";";
            SqlConnection conn = new SqlConnection(LaneDB);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    MessageBox.Show("Kết nối thành công");

                    //string cs = ConfigurationManager.ConnectionStrings[LaneDB].ConnectionString;
                    //using (conn = new SqlConnection(cs))
                    //{

                    //}
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
        private void btn_Apply_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(LaneDB);
            MessageBox.Show(StationDB);
            try
            {
                var source = new SchemaCompareDatabaseEndpoint(LaneDB);
                var target = new SchemaCompareDatabaseEndpoint(StationDB);
                var comparison = new SchemaComparison(source, target);
                var result = comparison.Compare();
                var differences = result.GenerateScript("ITD_SyncMonitor");
                string script = differences.Script;
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        
    }
}
