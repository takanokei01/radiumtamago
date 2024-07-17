namespace android;

public partial class Page12 : ContentPage
{
	public Page12()
	{
		InitializeComponent();
	}
    private async void OnClicked(object sender, EventArgs e)
    {
        // サブページへ移動
        await Shell.Current.GoToAsync("//Page11");
    }
    private async void OnClicked2(object sender, EventArgs e)
    {
        // サブページへ移動
        await Shell.Current.GoToAsync("//Page10");
    }
}