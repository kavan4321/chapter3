using chapter3.ViewModel.Profile;

namespace chapter3.pages;

public partial class Page3 : ContentPage
{
    private readonly Page3ViewModel _page3ViewModel;
    public Page3()
	{
		InitializeComponent();
        _page3ViewModel = (Page3ViewModel)BindingContext;
    }

    private void OtherButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        _page3ViewModel.DisplayCommand.Execute(this);
    }
}