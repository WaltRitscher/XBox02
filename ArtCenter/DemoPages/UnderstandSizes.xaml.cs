using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ArtCenter.DemoPages {
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class UnderstandSizesPage : Page {
    public UnderstandSizesPage() {
      this.InitializeComponent();
      this.Loaded += Page_Loaded;
      this.SizeChanged += Page_SizeChanged;
    }

    private void Page_SizeChanged(object sender, SizeChangedEventArgs e) {

      var bounds = ApplicationView.GetForCurrentView().VisibleBounds;
      var scaleFactor = DisplayInformation.GetForCurrentView().RawPixelsPerViewPixel;
      var size = new Size(bounds.Width * scaleFactor, bounds.Height * scaleFactor);
      SizeTextBlock.Text = $"Page Size: {this.ActualWidth} x {this.ActualHeight}, Scaling : {scaleFactor * 100}%";
    }

    private void Page_Loaded(object sender, RoutedEventArgs e) {
    
    }

    private void MainButton_Click(object sender, RoutedEventArgs e) {
   
    }
  }
}
