using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_task
{
    
    
    internal class Book
    {
        public string Title;
        public int Pages;
          public override string? ToString()
          {
            return $"Title: {Title} , Pages: {Pages}";
          }
    }

    

}
