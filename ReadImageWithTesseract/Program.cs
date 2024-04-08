using System;
using System.IO;
using Tesseract;

namespace ReadImageWithTesseract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OCR Console App");

            var filepath = "C:\\Projetos\\ReadImageWithTesseract\\";
            var imagePath = @$"{ filepath }image.png";

            using var engine = new TesseractEngine(@"C:\Projetos\ReadImageWithTesseract\ReadImageWithTesseract\tessdata\", "eng", EngineMode.Default);
            using var img = Pix.LoadFromFile(imagePath);
            using var page = engine.Process(img);

            var text = page.GetText();
                        
            
            Console.WriteLine("Texto encontrado na imagem:");
            Console.WriteLine(text);
                 

        }
    }
}
