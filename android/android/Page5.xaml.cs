namespace android;

public partial class Page5 : ContentPage
{
	public Page5()
	{
		InitializeComponent();
	}
	private async void OnClicked(object sender, EventArgs e)
		{
			// �T�u�y�[�W�ֈړ�
			await Shell.Current.GoToAsync("//Page6");
		}
}
	
