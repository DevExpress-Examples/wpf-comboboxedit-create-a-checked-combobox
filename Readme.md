<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128644481/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1971)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF ComboBoxEdit - Create a Checked ComboBox

This example demonstrates how to create a checked combo box. To do this, set the editor's [StyleSettings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.BaseEdit.StyleSettings) property to [CheckedComboBoxStyleSettings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.CheckedComboBoxStyleSettings):

```xaml
<dxe:ComboBoxEdit.StyleSettings>
   <dxe:CheckedComboBoxStyleSettings />
</dxe:ComboBoxEdit.StyleSettings>
```

![image](https://user-images.githubusercontent.com/65009440/199476164-4545c7c8-1c45-4b95-912b-edbe83434b01.png)

When you enable multiple selection in the [ComboBoxEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.ComboBoxEdit), its [EditValue](https://docs.devexpress.devx/WPF/DevExpress.Xpf.Editors.BaseEdit.EditValue) property must contain an object of the `List<object>` type. In this example, the `SelectedItemsConverter` converts the collection of selected `Customers` to `List<object>` and back.

## Files to Review

* [Customer.cs](./CS/ComboBoxEdit_CreatingCheckedComboBox/Customer.cs) (VB: [Customer.vb](./VB/ComboBoxEdit_CreatingCheckedComboBox/Customer.vb))
* [SelectedItemsConverter.cs](./CS/ComboBoxEdit_CreatingCheckedComboBox/SelectedItemsConverter.cs) (VB: [SelectedItemsConverter.vb](./VB/ComboBoxEdit_CreatingCheckedComboBox/SelectedItemsConverter.vb))
* [MyViewModel.cs](./CS/ComboBoxEdit_CreatingCheckedComboBox/ViewModels/MyViewModel.cs) (VB: [MyViewModel.vb](./VB/ComboBoxEdit_CreatingCheckedComboBox/ViewModels/MyViewModel.vb))
* [Window1.xaml](./CS/ComboBoxEdit_CreatingCheckedComboBox/Window1.xaml) (VB: [Window1.xaml](./VB/ComboBoxEdit_CreatingCheckedComboBox/Window1.xaml))

## Documentation

* [ComboBoxEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.ComboBoxEdit)
* [ComboBoxEdit Operation Modes](https://docs.devexpress.com/WPF/116528/controls-and-libraries/data-editors/common-features/editor-operation-modes/comboboxedit)
* [How to implement multi-select in DevExpress WPF Data Editors (ComboBoxEdit, LookUpEdit, ListBoxEdit)](https://supportcenter.devexpress.com/ticket/details/t889444/how-to-implement-multi-select-when-using-devexpress-wpf-data-editors-comboboxedit)

## More Examples

* [How to Apply Style Settings to the ComboBoxEdit](https://github.com/DevExpress-Examples/how-to-apply-style-settings-to-the-comboboxedit-e1982)
* [How to create ListBoxEdit, CheckedListBoxEdit and RadioListBoxEdit](https://github.com/DevExpress-Examples/how-to-create-listboxedit-checkedlistboxedit-and-radiolistboxedit-e3973)
* [WPF Data Grid - Assign a ComboBox Editor to a Column](https://github.com/DevExpress-Examples/wpf-data-grid-assign-combobox-editor-to-column)
