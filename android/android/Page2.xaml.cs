namespace android;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}
    private async void OnClicked(object sender, EventArgs e)
    {
        // �T�u�y�[�W�ֈړ�
        await Shell.Current.GoToAsync("//Page3");
    }
}