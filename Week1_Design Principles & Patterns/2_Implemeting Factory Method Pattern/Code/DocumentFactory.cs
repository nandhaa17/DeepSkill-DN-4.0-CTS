public abstract class DocumentFactory
{
    public abstract Document createDocument();
}

public class WordDocumentFactory : DocumentFactory
{
    public override Document createDocument()
    {
        return new WordDocument();
    }
}

public class PdfDocumentFactory : DocumentFactory
{
    public override Document createDocument()
    {
        return new PdfDocument();
    }
}

public class ExcelDocumentFactory : DocumentFactory
{
    public override Document createDocument()
    {
        return new ExcelDocument();
    }
}
