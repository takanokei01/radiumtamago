namespace android;

public partial class Page12 : ContentPage
{
	public Page12()
	{
		InitializeComponent();
	}
    private async void OnClicked(object sender, EventArgs e)
    {
        // �T�u�y�[�W�ֈړ�
      
    }
    private async void OnClicked2(object sender, EventArgs e)
    {
        // �T�u�y�[�W�ֈړ�
        await Shell.Current.GoToAsync("//NewPage1");
    }
}