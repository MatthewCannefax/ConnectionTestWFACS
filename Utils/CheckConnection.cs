using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using ConnectionTestWFACS.Model;

namespace ConnectionTestWFACS.Utils
{
    class CheckConnection
    {
        public CheckConnection(int interval, IPAddressMember ipMember, int timeout) {
            Interval = interval;
            IPMember = ipMember;
            Timeout = timeout;
        }

        public int Interval { get; set; }
        public IPAddressMember IPMember { get; set; }
        public int Timeout { get; set; }

        public void setTimer()
        {
            Timer timer = new Timer();
            timer.Elapsed += HandleTimerElapsed;
            timer.Interval = Interval;
            timer.Enabled = true;
        }

        private void HandleTimerElapsed(object sender, ElapsedEventArgs e)
        {
            pingHost(IPMember.IPAddress, Timeout);
        }

        public bool pingHost(string ip, int timeout)
        {
            Ping ping = new Ping();
            PingReply pingResult = ping.Send(ip, timeout * 1000);
            if (pingResult.Status.ToString().Equals("Success"))
            {
                return true;
            }
            return false;
        }
         
    }
}
