using Windows.Media.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ArtCenter {

  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class CustomSoundsPage : Page {

    public CustomSoundsPage() {
      this.InitializeComponent();
    }

    private void FocusButton_Click(object sender, RoutedEventArgs e) {
       PlaySound(new System.Uri("ms-appx:///Assets/Sounds/Clicker.mp3"));
    }

    private void ShowButton_Click(object sender, RoutedEventArgs e) {
       PlaySound(new System.Uri("ms-appx:///Assets/Sounds/Clicker.mp3"));
    }

    private void HideButton_Click(object sender, RoutedEventArgs e) {
       PlaySound(new System.Uri("ms-appx:///Assets/Sounds/Clicker.mp3"));
    }

    private void MoveNextButton_Click(object sender, RoutedEventArgs e) {
       PlaySound(new System.Uri("ms-appx:///Assets/Sounds/Clicker.mp3"));
    }

    private void MovePrevButton_Click(object sender, RoutedEventArgs e) {
       PlaySound(new System.Uri("ms-appx:///Assets/Sounds/Clicker.mp3"));
    }

    private void GoBackButton_Click(object sender, RoutedEventArgs e) {
       PlaySound(new System.Uri("ms-appx:///Assets/Sounds/Clicker.mp3"));
    }

    private void InvokeButton_Click(object sender, RoutedEventArgs e) {
      PlaySound(new System.Uri("ms-appx:///Assets/Sounds/Clicker.mp3"));
    }

   

    private void ComboBox_DropDownOpened(object sender, object e) {
      PlaySound(new System.Uri("ms-appx:///Assets/Sounds/Droner.mp3"));
    }

    private void ComboBox_DropDownClosed(object sender, object e) {
      PlaySound(new System.Uri("ms-appx:///Assets/Sounds/Droner2.mp3"));
    }
   
    internal void PlaySound(System.Uri uri) {
      
      clickerPlayer.Source = MediaSource.CreateFromUri(uri);
      clickerPlayer.MediaPlayer.Play();
    }

    private void Button_FocusEngaged(Control sender, FocusEngagedEventArgs args) {
       PlaySound(new System.Uri("ms-appx:///Assets/Sounds/Clicker.mp3"));
    }

   
  }
}