using System;

public class Program
{
    public static void Main(string[] args)
    {
        
            DocumentFactory wordFactory = new WordDocumentFactory();
            Document word = wordFactory.createDocument();
            word.creating();
            word.opening();
            word.saving();
            word.closing();
            Console.WriteLine("--------------------------------------------------");
            DocumentFactory pdfFactory = new PdfDocumentFactory();
            Document pdf = pdfFactory.createDocument();
            pdf.creating();
            pdf.opening();
            pdf.saving();
            pdf.closing();
            Console.WriteLine("--------------------------------------------------");
            DocumentFactory excelFactory = new ExcelDocumentFactory();
            Document excel = excelFactory.createDocument();
            excel.creating();
            excel.opening();
            excel.saving();
            excel.closing();
        
    }
}
