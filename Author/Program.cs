using GetAuthor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Author
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();


            //An instance of the interface is created
            GlobalConfig.AddIinstance();
            IAuthorInfo writer = GlobalConfig.Iinstance;
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Get Response method use the Http client to call the API 
            //It calls the API Twice since there are Two pages
            //Saves the Information into A list
            for (int pages = 1; pages <= 2; pages++)
            {
                GetResponse($"https://jsonmock.hackerrank.com/api/article_users/search?page={pages}");

            }
            Thread.Sleep(3000);

            Application.Run(new FormMajor(writer));


        }


        /// <summary>
        /// An Asynchronous method that uses an instance of HttpClient to fetch Information from the API
        /// Saves the content According to the class created in Root Class and Datum class
        /// Deserializes the Content using JsonSerializer and store the information into a LIst.
        /// </summary>
        /// <param name="url"></param>
        async static void GetResponse(string url)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(url);

            HttpContent content = response.Content;
                    
            string mycontent = await content.ReadAsStringAsync();
            RootDb myDeserializedClass = JsonSerializer.Deserialize<RootDb>(mycontent);
                     
            foreach (var item in myDeserializedClass.data)
            {
                AuthorInfo.Details.Add(item);
            }
        }
    }

}
