using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using XamarinSecureBackground.Models;

namespace XamarinSecureBackground.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<SecureCode> secureCodes;

        public MainViewModel()
        {
            SecureCodes = new ObservableCollection<SecureCode>()
            {
                new SecureCode()
                {
                    Title = "Facebook",
                    Code = "542366"
                },
                new SecureCode()
                {
                    Title = "Github",
                    Code = "755335"
                },
                new SecureCode()
                {
                    Title = "Outlook",
                    Code = "964344"
                },
                new SecureCode()
                {
                    Title = "Google",
                    Code = "534223"
                }
            };
        }      

        public ObservableCollection<SecureCode> SecureCodes
        {
            get { return secureCodes; }
            set
            {
                secureCodes = value;
                RaisePropertyChanged("SecureCodes");
            }
        }
               
        private void RaisePropertyChanged(string propertyName)
        {
            var handle = PropertyChanged;
            if (handle != null)
                handle(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
