using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GetAuthor
{
    /// <summary>
    /// The Class Implementing the IAuthor interface and it's Methods
    /// </summary>
    public class AuthorInfo : IAuthorInfo
    {

        /// <summary>
        /// Final List that stores the infomation from All of the pages fetched from the API.
        /// </summary>
        public static List<Datum> Details = new List<Datum>();

        /// <summary>
        /// This method uses Linq to query data from the Details list and get the username of Authors that have equals to or greater than the threshold provided.
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public List<string> GetUsernamesBySubmissionCount(int threshold)
        {
            var result = new List<string>();
            var query = Details.Where(x => x.submission_count >= threshold);
            foreach (var item in query)
                result.Add(item.username.ToString());

            return result;
        }

        /// <summary>
        /// This method uses Linq to query the Details list and get the Author with the highest Submission count.
        /// </summary>
        /// <returns></returns>
        public List<string> GetUsernamesByCommentCount()
        {
            var result = new List<string>();
            var query = Details.OrderByDescending(author => author.comment_count).Take(1);
            foreach (var item in query)
                result.Add(item.username.ToString());
            return result;
        }

        /// <summary>
        /// This method uses linq to query the Details list and get the Authors Sorted by when their record was created
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public  List<string> GetUsernamesByRecordDate(long threshold)
        {
            var result = new List<string>();
            var query = Details.Where(Author => Author.created_at <= threshold);
            foreach (var item in query)
            {
                result.Add(item.username.ToString());
            }
            return result;
        }
        

    }
}
