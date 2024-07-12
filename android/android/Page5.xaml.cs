namespace android;

public partial class Page5 : ContentPage
{
	public Page5()
	{
		InitializeComponent();
	}
	private async void OnClicked(object sender, EventArgs e)
		{
			// サブページへ移動
			await Shell.Current.GoToAsync("//Page6");
		}
    private async void OnClicked2(object sender, EventArgs e)
    {
        // サブページへ移動
        await Shell.Current.GoToAsync("//Page4");
    }
}
	
