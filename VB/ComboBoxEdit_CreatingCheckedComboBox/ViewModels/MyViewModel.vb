Imports System
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Linq

Namespace ComboBoxEdit_CreatingCheckedComboBox.ViewModels
	Public Class MyViewModel
		Implements INotifyPropertyChanged

        Private _selectedCustomers As ObservableCollection(Of Customer)
        Public Sub New()
            Customers = Customer.GetList()
            SelectedCustomers = New ObservableCollection(Of Customer)() From {Customers(1), Customers(2)}
        End Sub
        Public Property Customers() As ObservableCollection(Of Customer)
        Public Property SelectedCustomers() As ObservableCollection(Of Customer)
            Get
                Return _selectedCustomers
            End Get
            Set(ByVal value As ObservableCollection(Of Customer))
                If _selectedCustomers Is value Then
                    Return
                End If
                _selectedCustomers = value
                RaisePropertyChanged("SelectedCustomers")
            End Set
		End Property
		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
        Private Sub RaisePropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class
End Namespace
