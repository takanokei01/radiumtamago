namespace android;

public partial class Page8 : ContentPage
{
	public Page8()
	{
		InitializeComponent();
	}
    private async void OnClicked(object sender, EventArgs e)
    {
        // �T�u�y�[�W�ֈړ�
        await Shell.Current.GoToAsync("//Page9");
    }
   
}