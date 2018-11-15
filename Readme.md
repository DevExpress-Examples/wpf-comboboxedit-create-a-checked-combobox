<!-- default file list -->
*Files to look at*:

* [Customer.cs](./CS/ComboBoxEdit_CreatingCheckedComboBox/Customer.cs) (VB: [Customer.vb](./VB/ComboBoxEdit_CreatingCheckedComboBox/Customer.vb))
* [SelectedItemsConverter.cs](./CS/ComboBoxEdit_CreatingCheckedComboBox/SelectedItemsConverter.cs) (VB: [SelectedItemsConverter.vb](./VB/ComboBoxEdit_CreatingCheckedComboBox/SelectedItemsConverter.vb))
* [MyViewModel.cs](./CS/ComboBoxEdit_CreatingCheckedComboBox/ViewModels/MyViewModel.cs) (VB: [MyViewModel.vb](./VB/ComboBoxEdit_CreatingCheckedComboBox/ViewModels/MyViewModel.vb))
* **[Window1.xaml](./CS/ComboBoxEdit_CreatingCheckedComboBox/Window1.xaml) (VB: [Window1.xaml](./VB/ComboBoxEdit_CreatingCheckedComboBox/Window1.xaml))**
* [Window1.xaml.cs](./CS/ComboBoxEdit_CreatingCheckedComboBox/Window1.xaml.cs) (VB: [Window1.xaml](./VB/ComboBoxEdit_CreatingCheckedComboBox/Window1.xaml))
<!-- default file list end -->
# How to Create a Checked ComboBox


<p>The following example demonstrates how to create a checked combo box.</p>
<p>To enable this mode, set the editor's <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Editors.BaseEdit.StyleSettings.property"><u>StyleSettings</u></a> property to <a href="http://documentation.devexpress.com/#WPF/clsDevExpressXpfEditorsCheckedComboBoxStyleSettingstopic"><u>CheckedComboBoxStyleSettings</u></a>:</p>


```xaml
<dxe:ComboBoxEdit.StyleSettings>
   <dxe:CheckedComboBoxStyleSettings />
</dxe:ComboBoxEdit.StyleSettings>
```


<p><strong>Note </strong>that ComboBoxEdit supports several operation modes which are available through the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Editors.BaseEdit.StyleSettings.property">BaseEdit.StyleSettings</a> property. Please see the <a href="https://documentation.devexpress.com/WPF/116528/Controls-and-Libraries/Data-Editors/Common-Features/Editor-Operation-Modes/ComboBoxEdit">ComboBoxEdit</a> help topic to see the complete list.<br>For example, use <a href="http://documentation.devexpress.com/#WPF/clsDevExpressXpfEditorsRadioComboBoxStyleSettingstopic"><u>RadioComboBoxStyleSettings</u></a> to create a radio button list as demonstrated in the <a href="https://www.devexpress.com/Support/Center/p/E1982">E1982: How to Apply Style Settings to the ComboBoxEdit</a> example.</p>

<br/>


