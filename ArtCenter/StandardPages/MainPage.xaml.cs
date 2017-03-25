using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ArtCenter {

  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainPage : Page {

    public MainPage(Frame frame) {
      this.InitializeComponent();

      this.SidebarSplitView.Content = frame;
      this.Loaded += MainPage_Loaded;

      // for global event
      // use CoreWindow class.
      // Represents the Windows Store app with input events and basic user interface behaviors.
      CoreWindow.GetForCurrentThread().KeyUp += MainPage_KeyUp;

    }

    private async void MainPage_Loaded(object sender, RoutedEventArgs e) {
      var dataSource = await Models.WorkshopDataSource.CreateAsync();
      CategoryListbox.DataContext = dataSource.GetCategories();
    }
		
    private void MainPage_KeyUp(CoreWindow sender, KeyEventArgs e) {
      if (e.VirtualKey == Windows.System.VirtualKey.GamepadY)
      {
        FlyoutBase.ShowAttachedFlyout(SidebarSplitView);
      }
		
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
      theFrame.Navigate(typeof(InteractionPage));
      DemoOneButton.IsChecked = false;
    }

    private void DemoTwoButton_Checked(object sender, RoutedEventArgs e) {
      var theFrame = (Frame)SidebarSplitView.Content;

      theFrame.Navigate(typeof(KeepPointerPage));
      DemoTwoButton.IsChecked = false;
    }

    private void DemoThreeButton_Checked(object sender, RoutedEventArgs e) {
      var theFrame = (Frame)SidebarSplitView.Content;
      theFrame.Navigate(typeof(BrowserPage));
      DemoThreeButton.IsChecked = false;
    }


  }
}