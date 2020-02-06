using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesMovies4_2Lab
{
    class Movies
    {
        #region fields
        private string title;
        private string category;
        #endregion fields

        #region properties 
        public string Title { get => title; set => title = value; }
        public string Category { get => category; set => category = value; }
        #endregion properties 

        #region constructors 
        public Movies(string title, string category)
        {
            this.title = title;
            this.category = category;
        }
        #endregion constructors 

        #region methods
        public override string ToString()
        {
            return $"{title}";
        }
        #endregion methods 



    }
}
