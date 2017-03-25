using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ArtCenter {
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class TabDirectionPage : Page {
    public TabDirectionPage() {
      this.InitializeComponent();
    }

   

   

    private void Button_Click(object sender, RoutedEventArgs e) {
      var currentButton = sender as Button;
      currentButton.Visibility = Visibility.Collapsed;
      var nextButton = GetNextTab(currentButton.TabIndex);
      nextButton.Focus(FocusState.Programmatic);
    }

    private Button GetNextTab(int tabIndex) {
      var q = from b in MainGrid.Children.OfType<Button>()
              where b.TabIndex == tabIndex + 1
              select b;
      return q.First();
    }

    private void ResetButton_Click(object sender, RoutedEventArgs e) {
      
      foreach (Button item in MainGrid.Children.OfType<Button>())
      {
        item.Visibility = Visibility.Visible;
      }
			FirstButton.Focus(FocusState.Programmatic);
		}

		private void MoveToIsolatedButton_Click(object sender, RoutedEventArgs e) {
			IsolatedButton.Focus(FocusState.Programmatic);
		}
	}

}
