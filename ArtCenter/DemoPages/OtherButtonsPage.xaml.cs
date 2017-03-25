using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
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
  public sealed partial class OtherButtonsPage : Page {
    public OtherButtonsPage() {
      this.InitializeComponent();
      CoreWindow.GetForCurrentThread().KeyUp += OtherButtonsPage_KeyUp;
    }
    private const double Distance = 18;
    private void OtherButtonsPage_KeyUp(CoreWindow sender, KeyEventArgs args) {
      switch (args.VirtualKey)
      {
        case Windows.System.VirtualKey.None:
          break;
        case Windows.System.VirtualKey.GamepadRightThumbstickUp:
          Transform2.TranslateY -= Distance;
          break;
        case Windows.System.VirtualKey.GamepadRightThumbstickDown:
          Transform2.TranslateY += Distance;
          break;
        case Windows.System.VirtualKey.GamepadRightThumbstickLeft:
          Transform2.TranslateX -= Distance;
          break;
        case Windows.System.VirtualKey.GamepadRightThumbstickRight:
          Transform2.TranslateX += Distance;
          break;
        case Windows.System.VirtualKey.GamepadLeftShoulder:
          Projection1.RotationZ += Distance;
          break;
        case Windows.System.VirtualKey.GamepadRightShoulder:
          Projection1.RotationZ -= Distance;
          break;
        case Windows.System.VirtualKey.GamepadLeftTrigger:
          Projection1.RotationY += Distance;
          break;
        case Windows.System.VirtualKey.GamepadRightTrigger:
          Projection1.RotationY -= Distance;
          break;

        default:
          break;
      }
    }
  }
}
