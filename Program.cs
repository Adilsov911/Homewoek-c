using System;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentsProgram documentprogram = new DocumentsProgram();
            ExpertDocumentProgram expertdocumentprogram = new ExpertDocumentProgram();
            ProDocumentProgram prodocumentprogram = new ProDocumentProgram();

            //documentprogram.OpenDocument();
            //documentprogram.EditDocument();
            //documentprogram.SaveDocument();

            //expertdocumentprogram.SaveDocument();
            //expertdocumentprogram.OpenDocument();
            //expertdocumentprogram.EditDocument();

            prodocumentprogram.OpenDocument();
            prodocumentprogram.SaveDocument();
            prodocumentprogram.EditDocument();

        }
    }
}
