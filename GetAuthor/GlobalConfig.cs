using System;
using System.Collections.Generic;
using System.Text;

namespace GetAuthor
{
    public static class GlobalConfig
    {
        /// <summary>
        /// A class of Global Configurations
        /// It Creates ans Instance of the Interface
        /// Assigns the instance of the interface equals and intstance of the class 
        /// </summary>
        /// 
        //An instance of the Interface is created which is a static class
        public static IAuthorInfo Iinstance { get; private set; }


        //A method that can be used to add an instance of the of the interface
        public static void AddIinstance()
        {
            AuthorInfo writer = new AuthorInfo();
            Iinstance = writer;
        }


        //A method that can be used to remove the instance  of the interface
        public static void RemoveInstance()
        {
            Iinstance = null;
        }
    }
}
