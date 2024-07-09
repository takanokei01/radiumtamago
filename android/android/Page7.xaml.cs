namespace android;

public partial class Page7 : ContentPage
{
	public Page7()
	{
		InitializeComponent();
	}
    private async void OnClicked(object sender, EventArgs e)
    {
        // サブページへ移動
        await Shell.Current.GoToAsync("//Page8");
    }
}