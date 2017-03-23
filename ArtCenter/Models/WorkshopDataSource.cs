using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ArtCenter.Models
{
  public class WorkshopDataSource
  {
    private ObservableCollection<Workshop> _workshops = new ObservableCollection<Workshop>();

    private async Task<WorkshopDataSource> InitializeAsync()
    {
      await LoadWorkshopsFromApi();
      return this;
    }

    public static Task<WorkshopDataSource> CreateAsync()
    {
      var ret = new WorkshopDataSource();
      return ret.InitializeAsync();
    }

    public async Task LoadWorkshopsFromApi()
    {
      var client = new HttpClient();
      HttpResponseMessage response = await client.GetAsync(new Uri("http://orangevalleycaa.org/api/videos/"));
      var jsonString = await response.Content.ReadAsStringAsync();
      ObservableCollection<Workshop> workshops = 
						JsonConvert.DeserializeObject<ObservableCollection<Workshop>>(jsonString);
      _workshops = workshops;
    }

    public ObservableCollection<Workshop> GetWorkshops()
    {
      return _workshops;
    }

    public ObservableCollection<Workshop> GetPopularWorkshops()
    {
      var q = from w in GetWorkshops()
              orderby w.Popularity descending
              select w;
      return new ObservableCollection<Workshop>(q); ;
    }
  }
}