using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using forms.Model;

namespace forms.View_Model
{
    class ContactViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Contact> contacts { get; set; } = new ObservableCollection<Contact>()
        {
            new Contact(){ Id=1,Name="ABC",Mobile="123"},
            new Contact(){ Id=2,Name="DEF",Mobile="456"},
            new Contact(){ Id=3,Name="GHI",Mobile="789"}
        };

        private Contact? _selectedContact;
        public Contact SelectedContact
        {
            get { return SelectedContact1; }
            set
            {
                SelectedContact1 = value;
                OnPropertyChanged(nameof(SelectedContact));
            }
        }

        internal Contact? SelectedContact1 { get => _selectedContact; set => _selectedContact=value; }

        private void OnPropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void Addperson(string name, string mobile)
        {
            if (mobile.All(char.IsDigit))
            {
                int i = contacts.Any() ? contacts.Max(n => n.Id)+1 : 1;
                contacts.Add(new Contact() { Id = i, Name=name, Mobile=mobile });
            }
        }
        public void Updateperson(string name, string mobile)
        {
            if (mobile.All(char.IsDigit))
            {
                SelectedContact.Name = name;
                SelectedContact.Mobile = mobile;
            }
        }
        public void Deleteperson(string name, string mobile)
        {
            if (SelectedContact!=null)
            {
                contacts.Remove(SelectedContact);
            }
        }
    }
}
