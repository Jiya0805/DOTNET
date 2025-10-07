using forms.View_Model;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace forms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ContactViewModel cvm;
        public MainWindow()
        {
            InitializeComponent();
            cvm = new ContactViewModel();
            DataContext = cvm;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            cvm.Addperson(txtName.Text,txtMobile.Text);
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            cvm.Updateperson(txtName.Text, txtMobile.Text);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            cvm.Deleteperson(txtName.Text, txtMobile.Text);
        }
    }
}