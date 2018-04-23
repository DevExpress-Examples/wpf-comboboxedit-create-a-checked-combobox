Imports System
Imports System.Collections.ObjectModel
Imports System.Linq

Namespace ComboBoxEdit_CreatingCheckedComboBox
	Public Class Customer
		Public Property ID() As Integer
		Public Property Name() As String
		Public Shared Function GetList() As ObservableCollection(Of Customer)
			Dim customers As New ObservableCollection(Of Customer)()
			customers.Add(New Customer() With {
				.ID = 0,
				.Name = "David Miles"
			})
			customers.Add(New Customer() With {
				.ID = 1,
				.Name = "John Spor"
			})
			customers.Add(New Customer() With {
				.ID = 2,
				.Name = "Nick Jackson"
			})
			customers.Add(New Customer() With {
				.ID = 3,
				.Name = "Linda Parsons"
			})
			Return customers
		End Function
	End Class
End Namespace
