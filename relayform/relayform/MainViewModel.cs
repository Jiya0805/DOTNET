using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace relayform.commands
{
    public class MainViewModel
    {
        public RelayCommand showMessageCommand { get; }
        public MainViewModel()
        {
            showMessageCommand = new RelayCommand(_ => showMessage());
        }
            public void showMessage()
            {
                System.Windows.MessageBox.Show("Hello RelayCommand Works !");
            }
        
    }
}
