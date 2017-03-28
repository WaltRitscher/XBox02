using ArtCenter.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ArtCenter {

  public sealed partial class CatalogPage : Page {

    public CatalogPage() {
      this.InitializeComponent();

      this.Loaded += CatalogPage_Loaded;
    }

		private async void CatalogPage_Loaded(object sender, RoutedEventArgs e) {
      var dataSource = await WorkshopDataSource.CreateAsync();
			this.DataContext = dataSource.GetPopularWorkshops();
			gridView.LayoutUpdated += GridView_LayoutUpdated;

		}
		private void GridView_LayoutUpdated(object sender, object e) {

			var item = gridView.ContainerFromIndex(0) as GridViewItem;
			item.Focus(FocusState.Programmatic);
			gridView.LayoutUpdated -= GridView_LayoutUpdated;
		}


		protected override void OnNavigatedTo(NavigationEventArgs e) {
      base.OnNavigatedTo(e);
    }

    private void gridView_ItemClick(object sender, ItemClickEventArgs e) {
      var workshop = e.ClickedItem as Workshop;
      Frame.Navigate(typeof(VideoPage), workshop);
    }
  }
}