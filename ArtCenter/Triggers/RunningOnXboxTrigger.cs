using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace ArtCenter.Triggers {
  class RunningOnXboxTrigger : StateTriggerBase{
    private bool _isXbox;

  
    public bool IsXbox {
      get { return _isXbox; }
      set
      {
        _isXbox = value;
        if (Windows.System.Profile.AnalyticsInfo.VersionInfo.DeviceFamily=="Windows.Xbox")
        {
          SetActive(value);
        }
        else
        {
          SetActive(!value);
        }
      }
    }
  }
}
