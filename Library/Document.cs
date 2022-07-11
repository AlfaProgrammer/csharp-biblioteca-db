using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Biblioteca.Library
{
    public class Document
    {
        public string Identifier { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }

        public Document(string title, string category)
        {
            this.Title = title;
            this.Category = category;
        }
    }
}
