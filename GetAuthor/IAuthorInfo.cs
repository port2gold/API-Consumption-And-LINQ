using System;
using System.Collections.Generic;

namespace GetAuthor
{
    public interface IAuthorInfo
    {
        /// <summary>
        /// The methods that must be in the Class are created in the interface
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns></returns>
        /// 
        //This method Get Usernames By Submission Count
         List<string> GetUsernamesBySubmissionCount(int threshold);
        

        //This method Get Usernames By Comment Count
         List<string> GetUsernamesByCommentCount();

        //This method Get Usernames of Author Created Before a Given time
        List<string> GetUsernamesByRecordDate(long threshold);
        
            
        

    }
}
