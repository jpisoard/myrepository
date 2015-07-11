using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRepository.Object
{
    class Movie
    {
        public Movie(string title,string author)
        {
            this.title = title;
            this.author = author;
        }
        
        
        private string title;

        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        } 

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public override  String ToString()
        {
            return Title;
        }

    }
}
