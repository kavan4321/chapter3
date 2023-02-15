using chapter3.ViewModel.ColorPick;

namespace chapter3.pages;

public partial class Page7 : ContentPage
{
	private readonly Page7ViewModel _page7ViewModel;
	public Page7()
	{
		InitializeComponent();
		_page7ViewModel = new Page7ViewModel();
	}
}