using chapter3.ViewModel.QAQuiz;

namespace chapter3.pages;

public partial class Page8 : ContentPage
{
	private Page8ViewModel _page8ViewModel;
	public Page8()
	{
		InitializeComponent();

		_page8ViewModel = (Page8ViewModel)BindingContext;

	}

	int C = 0;

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        EnableButton();
    }

    private void RadioButton_CheckedChanged_1(object sender, CheckedChangedEventArgs e)
    {
        EnableButton();
    }
    private void NextButton_Clicked(object sender, EventArgs e)
    {
		C++;
		_page8ViewModel.Counts = C;
    }


    public void EnableButton()
    {
        if (Radio_Button.IsChecked == true || Radio_Button_1.IsChecked == true)
        {
            NextButton.IsEnabled = true;
            NextButton.TextColor = Colors.White;
        }
        else
        {
            NextButton.IsEnabled = false;
        }
    }
}