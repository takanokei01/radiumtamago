namespace android;

public partial class Page7 : ContentPage
{
	public Page7()
	{
		InitializeComponent();
	}
    private async void OnClicked(object sender, EventArgs e)
    {
        // �T�u�y�[�W�ֈړ�
        await Shell.Current.GoToAsync("//Page8");
    }
    private async void OnClicked2(object sender, EventArgs e)
    {
        // �T�u�y�[�W�ֈړ�
        await Shell.Current.GoToAsync("//Page6");
    }
}