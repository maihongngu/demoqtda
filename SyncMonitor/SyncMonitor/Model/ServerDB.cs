using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncMonitor.Model
{
    public class ServerDB
    {
        public int LaneID { get; set; }
        public string LaneCode { get; set; }
        public string Name { get; set; }
        public string StationCode { get; set; }
        public string IpAddress { get; set; }
        public System.DateTime LastTimeOnline { get; set; }
        public bool IsUsed { get; set; }
    }
}
