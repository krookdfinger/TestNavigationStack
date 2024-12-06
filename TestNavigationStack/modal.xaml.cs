using System.Diagnostics;

namespace TestNavigationStack;

public partial class modal : ContentPage
{
	public modal()
	{
		InitializeComponent();

        CounterBtn.BackgroundColor = Colors.Red;
    }
    private async void OnCounterClicked(object sender, EventArgs e)
    {
        charal.IsRunning = true;

        await Task.Delay(2000);

        await Navigation.PopModalAsync();

        charal.IsRunning = false;

    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        CounterBtn.BackgroundColor = Colors.Green;


    }

}