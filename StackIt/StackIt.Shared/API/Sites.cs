using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace StackIt.API {
    public class Sites {
        public List<Site> items { get; set; }
        public bool has_more { get; set; }
        public int quota_max { get; set; }
        public int quota_remaining { get; set; }
    }

    public class Styling {
        public string tag_background_color { get; set; }
        public string tag_foreground_color { get; set; }
        public string link_color { get; set; }
    }

    public class RelatedSite {
        public string relation { get; set; }
        public string api_site_parameter { get; set; }
        public string site_url { get; set; }
        public string name { get; set; }
    }

    public class Site {
        public Styling styling { get; set; }
        public List<RelatedSite> related_sites { get; set; }
        public List<string> aliases { get; set; }
        public List<string> markdown_extensions { get; set; }
        public int launch_date { get; set; }
        public string site_state { get; set; }
        public string high_resolution_icon_url { get; set; }
        public string favicon_url { get; set; }
        public string icon_url { get; set; }
        public string audience { get; set; }
        public string site_url { get; set; }
        public string api_site_parameter { get; set; }
        public string logo_url { get; set; }
        public string name { get; set; }
        public string site_type { get; set; }
        public string twitter_account { get; set; }
        public int? open_beta_date { get; set; }
        public int? closed_beta_date { get; set; }
    }
}
