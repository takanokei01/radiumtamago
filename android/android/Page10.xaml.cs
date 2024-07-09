namespace android;

public partial class Page10 : ContentPage
{
	public Page10()
	{
		InitializeComponent();
	}
    private async void OnClicked(object sender, EventArgs e)
    {
        // サブページへ移動
        await Shell.Current.GoToAsync("//MainPage");
    }
}