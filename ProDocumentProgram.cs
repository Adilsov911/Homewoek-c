using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class ProDocumentProgram : DocumentsProgram
    {
        public override void EditDocument()
        {
            Console.WriteLine("Dociment Edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
        }
        


    }
}
