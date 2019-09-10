using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionTestWFACS.Model
{
    class IPAddressMember
    {
        IPAddressMember() { }

        public IPAddressMember(string name, string ip) {
            Name = name;
            IPAddress = ip;
        }

        public string Name { get; set; }
        public string IPAddress { get; set; }

        public string getConnectionInfo(bool isReachable)
        {
            DateTime dt = new DateTime();
            string returnString = "";

            if (isReachable)
            {
                returnString = string.Format("{0} {1} online", dt.ToString(), Name);
            }
            else
            {
                returnString = string.Format("{0} {1} OFFLINE", dt.ToString(), Name);
            }

            return returnString;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
