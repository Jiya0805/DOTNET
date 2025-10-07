using relayform_predicate.Relay;
using relayform_predicate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace relayform_predicate.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public RelayCommand GreetCommand { get; set; }

        private string _username;

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; OnPropertyChanged(nameof(Username)); }
        }

        public MainViewModel()
        {
            GreetCommand = new RelayCommand(_ => { Greet(); });
        }

        public void Greet()
        {
            MessageBox.Show("Username: " + Username);
        }
    }
}
