using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class DocumentsProgram
    {
       public void OpenDocument()
       {
            Console.WriteLine("Dociment Opened");

       }

        public virtual void EditDocument()
        {   
            Console.WriteLine("Can Edit in Pro and Expert version");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert version");
        }
            
    }
}
