using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace ComboBoxEdit_CreatingCheckedComboBox.ViewModels
{
    public class MyViewModel : INotifyPropertyChanged
    {
        ObservableCollection<Customer> selectedCustomers;
        public MyViewModel() {
            Customers = Customer.GetList();
            SelectedCustomers = new ObservableCollection<Customer>() { Customers[1], Customers[2] };
        }
        public ObservableCollection<Customer> Customers { get; set; }
        public ObservableCollection<Customer> SelectedCustomers {
            get { return selectedCustomers; }
            set {
                if (selectedCustomers == value) {
                    return;
                }
                selectedCustomers = value;
                RaisePropertyChanged("SelectedCustomers");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        void RaisePropertyChanged(string propertyName) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
