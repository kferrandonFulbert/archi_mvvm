using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.Model;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Contact.ViewModel
{
    class ContactViewModel : INotifyPropertyChanged
    {
    private Contact.Model.Contact _contact;
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name
        {
            get { return _contact.Name; }
            set
            {
                _contact.Name = value;
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get { return _contact.Email; }
            set
            {
                _contact.Email = value;
                OnPropertyChanged();
            }
        }
        public ContactViewModel()
        {
            _contact = new Contact.Model.Contact();
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            
        }
    }
}
