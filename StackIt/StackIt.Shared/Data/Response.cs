using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace StackIt.Data {
    public class Response<T> {
        public ObservableCollection<T> items { get; set; }
        public bool has_more { get; set; }
        public int quota_max { get; set; }
        public int quota_remaining { get; set; }
    }
}
