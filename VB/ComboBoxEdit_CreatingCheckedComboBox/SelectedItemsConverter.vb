Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Globalization
Imports System.Linq
Imports System.Windows.Data
Imports System.Windows.Markup

Namespace ComboBoxEdit_CreatingCheckedComboBox
	Public Class SelectedItemsConverter
		Inherits MarkupExtension
		Implements IValueConverter

		Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
			Return Me
		End Function
		Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
			If value IsNot Nothing Then
				Return New List(Of Object)(DirectCast(value, IEnumerable(Of Object)))
			End If
			Return Nothing
		End Function
		Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
			Dim result As New ObservableCollection(Of Customer)()
			Dim enumerable = DirectCast(value, List(Of Object))
			If enumerable IsNot Nothing Then
				For Each item As Object In enumerable
					result.Add(DirectCast(item, Customer))
				Next item
			End If
			Return result
		End Function
	End Class
End Namespace
