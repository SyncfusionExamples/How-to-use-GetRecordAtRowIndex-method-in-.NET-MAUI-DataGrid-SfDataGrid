# How to use GetRecordAtRowIndex method in .NET MAUI DataGrid (SfDataGrid) ?
In this article, we will show you how to use GetRecordAtRowIndex method in [.Net Maui DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid).

## xaml
```
<ContentPage.BindingContext>
    <local:EmployeeViewModel x:Name="viewModel" />
</ContentPage.BindingContext>

<StackLayout>
    <HorizontalStackLayout>
        <Entry Placeholder="Enter the Index"
               WidthRequest="130"
               HeightRequest="50"
               x:Name="entry"
               Keyboard="Numeric" />

        <Button Text="Get Record"
                Clicked="Button_Clicked"
                WidthRequest="100"
                HeightRequest="50" />
    </HorizontalStackLayout>


    <syncfusion:SfDataGrid x:Name="dataGrid"
                           ColumnWidthMode="Auto"
                           GridLinesVisibility="Both"
                           HeaderGridLinesVisibility="Both"
                           AutoGenerateColumnsMode="None"
                           VerticalOptions="FillAndExpand"
                           HorizontalOptions="FillAndExpand"
                           ItemsSource="{Binding Employees}">

        <syncfusion:SfDataGrid.Columns>
            <syncfusion:DataGridNumericColumn MappingName="EmployeeID"
                                              Format="#"
                                              HeaderText="Employee ID" />
            <syncfusion:DataGridTextColumn MappingName="Name"
                                           HeaderText="Employee Name" />
            <syncfusion:DataGridTextColumn MappingName="Title"
                                           HeaderText="Designation" />
            <syncfusion:DataGridDateColumn MappingName="HireDate"
                                           HeaderText="Hire Date" />

        </syncfusion:SfDataGrid.Columns>
    </syncfusion:SfDataGrid>
</StackLayout>
``` 

## C#.
The code below demonstrates how to use GetRecordAtRowIndex method in DataGrid.
```
private void Button_Clicked(object sender, EventArgs e)
{
    if (int.TryParse(entry.Text, out int index) && index >= 0)
    {
        var record = dataGrid.GetRecordAtRowIndex(index);

        if (record != null)
        {
            DisplayAlert("Record Found",
                         $"Employee ID: {((Employee)record).EmployeeID}\n" +
                         $"Name: {((Employee)record).Name}\n" +
                         $"Title: {((Employee)record).Title}\n" +
                         $"Hire Date: {((Employee)record).HireDate:MM/dd/yyyy}",
                         "OK");
        }
        else
        {
            DisplayAlert("Not Found", "No record exists at the given index.", "OK");
        }
    }
    else
    {
        DisplayAlert("Error", "Please enter a valid positive number.", "OK");
    }

}
```

![GetRecord.gif](https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjMzOTY5Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.7gYv-MWHxrH5TaCOKC7wUmr3wbELDWiKDeRq2usZvAg)

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-use-GetRecordAtRowIndex-method-in-.NET-MAUI-DataGrid-SfDataGrid)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to use GetRecordAtRowIndex method in .NET MAUI DataGrid (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!