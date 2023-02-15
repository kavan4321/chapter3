using chapter3.ViewModel;
using chapter3.ViewModel.ConfirmDelete;

namespace chapter3.pages;

public partial class Page4 : ContentPage
{
	private readonly Page4ViewModel _page4ViewModel;
	public Page4()
	{
		InitializeComponent();
        _page4ViewModel = (Page4ViewModel)BindingContext;
    }

    private void ConfirmCheck_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        _page4ViewModel.EnableCommand.Execute(this);
    }
}