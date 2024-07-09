namespace android;

public partial class Page4 : ContentPage
{
	public Page4()
	{
		InitializeComponent();
	}
    private async void OnClicked(object sender, EventArgs e)
    {
        // サブページへ移動
        await Shell.Current.GoToAsync("//Page5");
    }
}