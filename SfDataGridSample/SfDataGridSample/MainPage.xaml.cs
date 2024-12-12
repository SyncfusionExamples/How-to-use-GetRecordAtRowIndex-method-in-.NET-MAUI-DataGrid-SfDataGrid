using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.DataGrid.Exporting;
using Syncfusion.Maui.DataGrid.Helper;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

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
    }
}
