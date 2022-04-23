using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dusty
{
    /// <summary>
    /// A Special Class designed to Convert to Json Format 
    /// </summary>
    public class JsonClass : Notify, IJsonFormat
    {
        string format, description, author; 

        public JsonClass()
        {
            //Everything is null 
            format = "";
            description = "";
            author = "";
            
        }
       
        public string Format 
        {
            get => format;
            init { format = value; OnPropertyChanged("Format"); } 
        }
        public string Description
        {
            get => description;
            init { description = value; OnPropertyChanged("Description"); }  
        }
        public string Author
        {
            get => author;
            init { author = value; OnPropertyChanged("Author"); }
        }
    }
}
