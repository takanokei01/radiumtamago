namespace android;

public partial class Page4 : ContentPage
{
	public Page4()
	{
		InitializeComponent();
	}
    private async void OnClicked(object sender, EventArgs e)
    {
        // �T�u�y�[�W�ֈړ�
        await Shell.Current.GoToAsync("//Page5");
    }
}