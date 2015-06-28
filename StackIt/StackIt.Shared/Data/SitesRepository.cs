using StackIt.API;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using Windows.Storage;
using System.Linq;

namespace StackIt.Data {
    public class SitesRepository : Response<Site> {
        public static async Task<IEnumerable<Site>> AllSites() {
            string jsonText = await FileIO.ReadTextAsync(await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///DataModel/sites.json")));
            return JsonConvert.DeserializeObject<Response<Site>>(jsonText).items;
        }
        public static async Task<IEnumerable<Site>> MainSites() {
            return (await AllSites()).Where(s => s.site_type != "meta_site");
        }
    }
}
