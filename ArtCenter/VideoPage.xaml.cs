using ArtCenter.Models;
using Windows.Media.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace ArtCenter {

  public sealed partial class VideoPage : Page {

    public VideoPage() {
      this.InitializeComponent();
    }

    protected override void OnNavigatedTo(NavigationEventArgs e) {
      base.OnNavigatedTo(e);
      _workshop = e.Parameter as Workshop;
      this.DataContext = _workshop;
      PlayVideo();
    }

    protected override void OnNavigatedFrom(NavigationEventArgs e) {
      base.OnNavigatedFrom(e);
      this.DataContext = null;
      playerElement.MediaPlayer.Pause();
    }

    private Workshop _workshop;

    internal void PlayVideo() {
      var pathUri = new System.Uri((_workshop.VideoPath));
      playerElement.Source = MediaSource.CreateFromUri(pathUri);
      playerElement.MediaPlayer.Play();
    }
  }
}