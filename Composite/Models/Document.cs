using Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Composite.Models
{
    public class Document : IDocumentComponent
    {
        private readonly List<IDocumentComponent> _sections = new();

        public void Add(IDocumentComponent component)
        {
            _sections.Add(component);
        }

        public void Remove(IDocumentComponent component)
        {
            _sections.Remove(component);
        }

        public void Display(int depth = 0)
        {
            Console.WriteLine("Структура документа:");
            foreach (var section in _sections)
            {
                section.Display(depth + 2);
            }
        }
    }
}
