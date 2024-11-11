// See https://aka.ms/new-console-template for more information
using Composite.Models;

class Program
{
    static void Main()
    {
        
        var paragraph1 = new Paragraph("Первый параграф");
        var paragraph2 = new Paragraph("Второй параграф");

       
        var section1 = new Section("Раздел 1");
        var section2 = new Section("Раздел 2");

        
        section1.Add(paragraph1);
        section2.Add(paragraph2);

        
        var subsection = new Section("Подраздел 2.1");
        subsection.Add(new Paragraph("Это пункт в подразделе"));
        section2.Add(subsection);

     
        var document = new Document();
        document.Add(section1);
        document.Add(section2);

       
        document.Display();
    }
}
