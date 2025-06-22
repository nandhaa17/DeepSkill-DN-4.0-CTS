using System;

public class PdfDocument : Document
{
    public void creating()
    {
        Console.WriteLine("Creating a PdfDocument");
    }

    public void opening()
    {
        Console.WriteLine("Opening a PdfDocument");
    }

    public void saving()
    {
        Console.WriteLine("Saving a PdfDocument");
    }

    public void closing()
    {
        Console.WriteLine("Closing a PdfDocument");
    }
}
