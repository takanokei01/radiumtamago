namespace android;

public partial class Page9 : ContentPage
{
	public Page9()
	{
		InitializeComponent();
	}
    private async void OnClicked(object sender, EventArgs e)
    {
        // サブページへ移動
        await Shell.Current.GoToAsync("//Page10");
    }
    
}