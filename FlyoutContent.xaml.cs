namespace FlyoutLeak;

public partial class FlyoutContent : ContentPage
{
	public FlyoutContent()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        memoryLabel.Text = GC.GetTotalMemory(true).ToString();
    }

    private void OnButtonClicked(object sender, EventArgs args)
    {
        Application.Current.MainPage = new MemoryFlyPage();
    }
}
