using chapter3.ViewModel.MyCart;
using CommunityToolkit.Maui.Alerts;

namespace chapter3.View;

public partial class Page5 : ContentPage
{
	private Page5ViewModel _page5ViewModel;
	
    public Page5()
	{
		InitializeComponent();
        _page5ViewModel = (Page5ViewModel)BindingContext;
    }

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        _page5ViewModel.CalculateCommand.Execute(this);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        _page5ViewModel.CalculateCommand.Execute(this);
    }

    private void Apply_Clicked(object sender, EventArgs e)
    {
        _page5ViewModel.CalculateCommand.Execute(this);
        _page5ViewModel.ApplyCommand.Execute(this);
    }

}