using System;

namespace FactoryMethodExample
{
    abstract class Document
    {
        public abstract void Open();
    }

    class PdfDocument : Document
    {
        public override void Open() { Console.WriteLine("Відкрито PDF-документ"); }
    }

    class WordDocument : Document
    {
        public override void Open() { Console.WriteLine("Відкрито Word-документ"); }
    }

    class ExcelDocument : Document
    {
        public override void Open() { Console.WriteLine("Відкрито Excel-документ"); }
    }

    abstract class DocumentCreator
    {
        public abstract Document CreateDocument();
    }

    class PdfCreator : DocumentCreator
    {
        public override Document CreateDocument() { return new PdfDocument(); }
    }

    class WordCreator : DocumentCreator
    {
        public override Document CreateDocument() { return new WordDocument(); }
    }

    class ExcelCreator : DocumentCreator
    {
        public override Document CreateDocument() { return new ExcelDocument(); }
    }

    public class FactoryMethodTask
    {
        public static void Run()
        {
            DocumentCreator creator = new PdfCreator();
            creator.CreateDocument().Open();

            creator = new WordCreator();
            creator.CreateDocument().Open();

            creator = new ExcelCreator();
            creator.CreateDocument().Open();
        }
    }
}