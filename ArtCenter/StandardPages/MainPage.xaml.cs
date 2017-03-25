using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ArtCenter {

  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainPage : Page {

    public MainPage(Frame frame) {
      this.InitializeComponent();

      this.SidebarSplitView.Content = frame;
    }

    private void MenuButton_Checked(object sender, RoutedEventArgs e) {
      SidebarSplitView.IsPaneOpen = true;
      LogoText.Visibility = Visibility.Visible;
    }

    private void MenuButton_Unchecked(object sender, RoutedEventArgs e) {
      SidebarSplitView.IsPaneOpen = false;
      LogoText.Visibility = Visibility.Collapsed;
    }

    private void HomeButton_Checked(object sender, RoutedEventArgs e) {
      var theFrame = (Frame)SidebarSplitView.Content;
      theFrame.Navigate(typeof(CatalogPage));
      HomeButton.IsChecked = false;
    }

    private void DemoOneButton_Checked(object sender, RoutedEventArgs e) {
      var theFrame = (Frame)SidebarSplitView.Content;

      theFrame.Navigate(typeof(TabDirectionPage));
      DemoOneButton.IsChecked = false;
    }

    private void DemoTwoButton_Checked(object sender, RoutedEventArgs e) {
      var theFrame = (Frame)SidebarSplitView.Content;
      
      DemoTwoButton.IsChecked = false;
    }

    private void DemoThreeButton_Checked(object sender, RoutedEventArgs e) {
      var theFrame = (Frame)SidebarSplitView.Content;
      // theFrame.Navigate(typeof(VideoPage));
      DemoThreeButton.IsChecked = false;
    }
  }
}