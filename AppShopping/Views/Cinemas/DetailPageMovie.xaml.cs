namespace AppShopping.Views.Cinemas;

public partial class DetailPageMovie : ContentPage
{
	bool first = false;
	public DetailPageMovie()
	{
		InitializeComponent();
	}

    private void PlayPause(object sender, TappedEventArgs e)
    {

		if(MediaTrailer.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
		{
			MediaTrailer.Pause();
            play.FadeTo(1, 500);
            play.Source = ImageSource.FromFile("play.png");
		}
		else
		{
			MediaTrailer.Play();
            play.FadeTo(0, 500);
            play.Source = ImageSource.FromFile("pause.png");
			ImageMovie.IsVisible = false;
		}
    }
}