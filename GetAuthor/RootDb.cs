using System;
using System.Collections.Generic;
using System.Text;

namespace GetAuthor
{
    public class RootDb
    {
        //Root Database Class

        //This class contains the page information from the API
        public string page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public List<Datum> data { get; set; }
    }
}
