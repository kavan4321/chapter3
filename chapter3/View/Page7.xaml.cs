using chapter3.ViewModel.ColorPick;

namespace chapter3.pages;

public partial class Page7 : ContentPage
{
	private readonly Page7ViewModel _page7ViewModel;
	public Page7()
	{
		InitializeComponent();
        _page7ViewModel = (Page7ViewModel)BindingContext;
    }
  
    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		_page7ViewModel.Values();
    }
}