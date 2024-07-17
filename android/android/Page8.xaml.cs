namespace android;

public partial class Page8 : ContentPage
{
	public Page8()
	{
		InitializeComponent();
	}
    private async void OnClicked(object sender, EventArgs e)
    {
        // サブページへ移動
        await Shell.Current.GoToAsync("//Page9");
    }
    private async void OnClicked2(object sender, EventArgs e)
    {
        // サブページへ移動
        await Shell.Current.GoToAsync("//Page7");
    }

}