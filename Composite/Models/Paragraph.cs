using Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Models
{
    public class Paragraph : IDocumentComponent
    {
        public string Text { get; set; }

        public Paragraph(string text)
        {
            Text = text;
        }

        public void Add(IDocumentComponent component)
        {
            
        }

        public void Remove(IDocumentComponent component)
        {
            
        }

        public void Display(int depth = 0)
        {
            Console.WriteLine(new string('-', depth) + Text);
        }
    }
}
