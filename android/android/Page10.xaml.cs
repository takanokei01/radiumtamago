namespace android;

public partial class Page10 : ContentPage
{
	public Page10()
	{
		InitializeComponent();
	}
    private async void OnClicked(object sender, EventArgs e)
    {
        // �T�u�y�[�W�ֈړ�
        await Shell.Current.GoToAsync("//MainPage");
    }
}