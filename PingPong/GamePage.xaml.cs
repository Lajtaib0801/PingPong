using PingPong.ViewModels;

namespace PingPong;

public partial class GamePage : ContentPage
{
	public GamePage(GameViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		Frame tapedFrame = ((Frame)sender);
		if (tapedFrame.RotationX == 180)
			plyOnePoint.Text = (int.Parse(plyOnePoint.Text)+1).ToString();
		else
            plyTwoPoint.Text = (int.Parse(plyTwoPoint.Text) + 1).ToString();
		CheckWinner();
    }

	private async void CheckWinner(){
		int pOnePoint = int.Parse(plyOnePoint.Text);
		int pTwoPoint = int.Parse(plyTwoPoint.Text);
		if((pOnePoint >= 11 || pTwoPoint >= 11) && Math.Abs(pOnePoint-pTwoPoint) >= 2)
		{
			bool answer = await DisplayAlert("Játék vége!", $"A gyõztes: {(pOnePoint > pTwoPoint ? plyOneName.Text : plyTwoName.Text)}\nAkar új játékot kezdeni?", "Yes", "No");
			if (answer)
			{
				plyOnePoint.Text = plyTwoPoint.Text = "0";

            }
			else
			{
				Application.Current.Quit();
			}
		}
		
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        plyOnePoint.Text = plyTwoPoint.Text = "0";
    }


}