using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace StackIt.API {
    public class Site {
        public Styling styling { get; set; }
        public ObservableCollection<RelatedSite> related_sites { get; set; }
        public ObservableCollection<String> aliases { get; set; }
        public ObservableCollection<String> markdown_extensions { get; set; }
        public int launch_date { get; set; }
        public String site_state { get; set; }
        public String high_resolution_icon_url { get; set; }
        public String favicon_url { get; set; }
        public String icon_url { get; set; }
        public String audience { get; set; }
        public String site_url { get; set; }
        public String api_site_parameter { get; set; }
        public String logo_url { get; set; }
        public String name { get; set; }
        public String site_type { get; set; }
        public String twitter_account { get; set; }
        public int? open_beta_date { get; set; }
        public int? closed_beta_date { get; set; }
    }

    public class Styling {
        public String tag_background_color { get; set; }
        public String tag_foreground_color { get; set; }
        public String link_color { get; set; }
    }

    public class RelatedSite {
        public String relation { get; set; }
        public String api_site_parameter { get; set; }
        public String site_url { get; set; }
        public String name { get; set; }
    }
}
