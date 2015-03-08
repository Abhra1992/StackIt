using StackIt.API;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using Windows.Storage;

namespace StackIt.Data {
    public class SitesRepository {
        public ObservableCollection<Site> items { get; set; }
        public static async Task<IEnumerable<Site>> GetSites() {
            string jsonText = await FileIO.ReadTextAsync(await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///DataModel/sites.json")));
            return JsonConvert.DeserializeObject<Sites>(jsonText).items;
        }
    }
}
