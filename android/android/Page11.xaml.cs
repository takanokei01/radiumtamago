namespace android;

public partial class Page11 : ContentPage
{
	public Page11()
	{
		InitializeComponent();
	}
    private async void OnClicked(object sender, EventArgs e)
    {
        // �T�u�y�[�W�ֈړ�
        await Shell.Current.GoToAsync("//MainPage");
    }
    private async void OnClicked2(object sender, EventArgs e)
    {
        // �T�u�y�[�W�ֈړ�
        await Shell.Current.GoToAsync("//Page9");
    }
}