namespace android;

public partial class Page6 : ContentPage
{
	public Page6()
	{
		InitializeComponent();
	}
    private async void OnClicked(object sender, EventArgs e)
    {
        // サブページへ移動
        await Shell.Current.GoToAsync("//Page7");
    }
}