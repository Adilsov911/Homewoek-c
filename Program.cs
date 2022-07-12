using System;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = "expertt";
            if (type == "basic")
            {
                DocumentsProgram documentsProgram = new DocumentsProgram();
                documentsProgram.OpenDocument();
                documentsProgram.EditDocument();
                documentsProgram.SaveDocument();
            }
            else if (type == "pro")
            {
                ProDocumentProgram prodocumentsProgram = new ProDocumentProgram();

                prodocumentsProgram.OpenDocument();
                prodocumentsProgram.EditDocument();
                prodocumentsProgram.SaveDocument();

            }
            else if (type == "expert")
            {
                ExpertDocumentProgram expertDocumentsProgram = new ExpertDocumentProgram();
                expertDocumentsProgram.OpenDocument();
                expertDocumentsProgram.EditDocument();
                expertDocumentsProgram.SaveDocument();           
            }
            else
            {
                Console.WriteLine("Keyword is not correkt");
            }
            

            

        }
    }
}
