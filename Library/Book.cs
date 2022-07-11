using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Biblioteca.Library
{
    public class Book : Document
    {
        public int Pages { get; set; }

        public Book(string title, string category) : base(title, category) { }
        
        // METHOD PER AGGIUNGERE UN LIBRO ALLA TABELLA 
        
    }

}
