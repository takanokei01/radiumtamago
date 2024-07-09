namespace android;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}
    private async void OnClicked(object sender, EventArgs e)
    {
        // サブページへ移動
        await Shell.Current.GoToAsync("//Page3");
    }
}