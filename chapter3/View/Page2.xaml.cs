using chapter3.ViewModel.DisplayRandomQuote;
using chapter3.ViewModel.Temp;

namespace chapter3.pages;

public partial class Page2 : ContentPage
{
    private readonly Page2ViewModel _page2ViewModel;
    public Page2()
	{
		InitializeComponent();
        _page2ViewModel = (Page2ViewModel)BindingContext;
    }
}