namespace android;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}
    private async void OnClicked(object sender, EventArgs e)
    {
        // �T�u�y�[�W�ֈړ�
        await Shell.Current.GoToAsync("//Page4");
    }
    private async void OnClicked2(object sender, EventArgs e)
    {
        // �T�u�y�[�W�ֈړ�
        await Shell.Current.GoToAsync("//Page2");
    }
}