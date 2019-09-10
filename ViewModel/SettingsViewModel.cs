using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectionTestWFACS.Model;
using ConnectionTestWFACS.Utils;

namespace ConnectionTestWFACS.ViewModel
{
    class SettingsViewModel : INotifyPropertyChanged
    {
        public IntervalInteger currentInterval { get; set; }

        public List<string> connectionReportList { get; set; }
        public ObservableCollection<string> connectionReportObservable { get; set; }

        public List<IPAddressMember> iPAddressMembers { get; set; }
        public ObservableCollection<string> ipAddressMembersObservable { get; set; }

        public List<CheckConnection> connectionTimers { get; set; }

        SettingsViewModel() {
            //ipAddressMembers should be set using the JSONhelper once that gets up and running!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //also set up the observable list to go along with the ipAddressMembers list!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            //set the currentInterval using JSONHelper
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void setInterval(int interval) {
            currentInterval.Interval = interval;
            //save the current interval with JSONHelper
        }

        public void startButton() {
            connectionReportObservable = new ObservableCollection<string>();
            connectionReportList = new List<string>();

            connectionTimers = new List<CheckConnection>();
        }

        public void stopButton()
        {
            try {
                if (File.Exists(Constants.CONNECTION_LOG_FILE_NAME))
                {
                    File.Delete(Constants.CONNECTION_LOG_FILE_NAME);
                }

                using(FileStream fs = File.Create(Constants.CONNECTION_LOG_FILE_NAME))
                {
                    connectionReportList.ForEach(cr => 
                    {
                        //write the file here
                        //some sample code
                        //Byte[] title = new UTF8Encoding(true).GetBytes("New Text File");
                        //fs.Write(title, 0, title.Length);
                        //byte[] author = new UTF8Encoding(true).GetBytes("Mahesh Chand");
                        //fs.Write(author, 0, author.Length);
                    });
                    
                }
            }catch(IOException e)
            {

            }
        }

        public void addToIPListButton(string nameValue, string ipValue) {
            IPAddressMember ipMem = new IPAddressMember(nameValue, ipValue);
            iPAddressMembers.Add(ipMem);
            ipAddressMembersObservable.Add(ipMem.ToString());
            //also save to the JSON file
        }
    }
}
