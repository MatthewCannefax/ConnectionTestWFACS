using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionTestWFACS.Model
{
    static class Constants
    {
        public const string IP_ADDRESS_PATTERN = "^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";

        public const string INTERVAL_FILE_NAME = "interval-file";

        public const string IP_FILE_NAME = "ip-file";

        public const int DEFAULT_INTERVAL = 10;

        public const int DEFAULT_TIMEOUT = 1000;

        public const string CONNECTION_LOG_FILE_NAME = "connection-log.txt";
    }
}
