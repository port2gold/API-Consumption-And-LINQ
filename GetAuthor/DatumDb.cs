using System;
using System.Collections.Generic;
using System.Text;

namespace GetAuthor
{
    public class Datum
    {
        /// <summary>
        /// The Datum class contains the individual table head from the API
        /// </summary>
        /// 
        //Author Id
        public int id { get; set; }

        //Author Username field
        public string username { get; set; }

        //Author About field
        public string about { get; set; }

        //Author Submitted
        public int submitted { get; set; }
        

        //Author Update At field
        public DateTime updated_at { get; set; }

        //Author Submission Count field
        public int submission_count { get; set; }

        //Author Comment Count
        public int comment_count { get; set; }

        //Author Created At field
        public int created_at { get; set; }
    }
}
