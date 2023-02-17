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


    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
      
    }

    private void SplitSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
       
    }
}
