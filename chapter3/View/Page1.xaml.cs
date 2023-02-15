namespace chapter3.View;
using chapter3.ViewModel.DisplayRandomQuote;

public partial class Page1 : ContentPage
{
	private readonly Page1ViewModel _page1ViewModel;
	public Page1()
	{
		
		InitializeComponent();
        _page1ViewModel = (Page1ViewModel)BindingContext;
         
    }

    

}