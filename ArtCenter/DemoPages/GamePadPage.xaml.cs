using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ArtCenter
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class GamePadPage : Page
  {
    public GamePadPage()
    {
      this.InitializeComponent();

      this.KeyDown += GamePadPage_KeyDown;
    }

    private void GamePadPage_KeyDown(object sender, KeyRoutedEventArgs e)
    {
      if (e.Handled)
      {
        return;
      }
      MessageTextBlock.Text = e.Key.ToString();
    }

   

    
  }
}