using System;

namespace FactoryMethodPatternExample
{
    // 1. Define Document interface/abstract class
    public abstract class Document
    {
        public abstract void Open();
    }

    // 2. Concrete Document Classes
    public class WordDocument : Document
    {
        public override void Open() => Console.WriteLine("Opening Word Document (.docx)...");
    }

    public class PdfDocument : Document
    {
        public override void Open() => Console.WriteLine("Opening PDF Document (.pdf)...");
    }

    public class ExcelDocument : Document
    {
        public override void Open() => Console.WriteLine("Opening Excel Document (.xlsx)...");
    }

    // 3. Abstract Factory Class
    public abstract class DocumentFactory
    {
        public abstract Document CreateDocument();
    }

    // 4. Concrete Factory Classes
    public class WordDocumentFactory : DocumentFactory
    {
        public override Document CreateDocument() => new WordDocument();
    }

    public class PdfDocumentFactory : DocumentFactory
    {
        public override Document CreateDocument() => new PdfDocument();
    }

    public class ExcelDocumentFactory : DocumentFactory
    {
        public override Document CreateDocument() => new ExcelDocument();
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Test the Factory Method Implementation
            Console.WriteLine("--- Document Management System ---");

            DocumentFactory wordFactory = new WordDocumentFactory();
            Document wordDoc = wordFactory.CreateDocument();
            wordDoc.Open();

            DocumentFactory pdfFactory = new PdfDocumentFactory();
            Document pdfDoc = pdfFactory.CreateDocument();
            pdfDoc.Open();
            
            DocumentFactory excelFactory = new ExcelDocumentFactory();
            Document excelDoc = excelFactory.CreateDocument();
            excelDoc.Open();
        }
    }
}