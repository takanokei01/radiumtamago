namespace android;

public partial class Page11 : ContentPage
{
	public Page11()
	{
		InitializeComponent();
	}
    private async void OnClicked(object sender, EventArgs e)
    {
        // サブページへ移動
        await Shell.Current.GoToAsync("//Page12");
    }
    private async void OnClicked2(object sender, EventArgs e)
    {
        // サブページへ移動
        await Shell.Current.GoToAsync("//Page10");
    }
}