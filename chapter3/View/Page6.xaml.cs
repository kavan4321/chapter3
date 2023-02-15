using chapter3.ViewModel.DisplayRandomQuote;
using chapter3.ViewModel.Tip;
using CommunityToolkit.Maui.Alerts;


namespace chapter3.pages;

public partial class Page6 : ContentPage
{
	private readonly Page6ViewModel _page6ViewModel;
	public Page6()
	{
		InitializeComponent();
        _page6ViewModel = (Page6ViewModel)BindingContext;
    }

    private void TipSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if (string.IsNullOrEmpty(BillEntry.Text))
        {
            Toast.Make("Please Enter Value", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
        }
        else if (double.Parse(BillEntry.Text) < 100 || double.Parse(BillEntry.Text) > 50000)
        {
            Toast.Make("Enter Value Between 100 & 50000", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
        }
    }
  
}
