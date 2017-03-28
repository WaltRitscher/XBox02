using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ArtCenter {

  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class AvailableSoundsPage : Page {

    public AvailableSoundsPage() {
      this.InitializeComponent();
    }

    private void FocusButton_Click(object sender, RoutedEventArgs e) {
      ElementSoundPlayer.Play(ElementSoundKind.Focus);
    }

    private void ShowButton_Click(object sender, RoutedEventArgs e) {
      ElementSoundPlayer.Play(ElementSoundKind.Show);
    }

    private void HideButton_Click(object sender, RoutedEventArgs e) {
      ElementSoundPlayer.Play(ElementSoundKind.Hide);
    }

    private void MoveNextButton_Click(object sender, RoutedEventArgs e) {
      ElementSoundPlayer.Play(ElementSoundKind.MoveNext);
    }

    private void MovePrevButton_Click(object sender, RoutedEventArgs e) {
      ElementSoundPlayer.Play(ElementSoundKind.MovePrevious);
    }

    private void GoBackButton_Click(object sender, RoutedEventArgs e) {
      ElementSoundPlayer.Play(ElementSoundKind.GoBack);
    }

    private void InvokeButton_Click(object sender, RoutedEventArgs e) {
      ElementSoundPlayer.Play(ElementSoundKind.Invoke);
    }

    private void ComboBox_DropCompleted(UIElement sender, DropCompletedEventArgs args) {
      ElementSoundPlayer.Play(ElementSoundKind.Show);
    }

    private void ComboBox_DropDownOpened(object sender, object e) {
      ElementSoundPlayer.Play(ElementSoundKind.Show);
    }
  }
}