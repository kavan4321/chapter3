using chapter3.ViewModel.Tip;
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
        _page6ViewModel.Calculation();
    }
   
    

    private void SplitSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        _page6ViewModel.Calculation();
    }
}
