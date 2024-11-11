using Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Models
{
    public class Section : IDocumentComponent
    {
        public string Title { get; set; }
        private readonly List<IDocumentComponent> _components = new();

        public Section(string title)
        {
            Title = title;
        }

        public void Add(IDocumentComponent component)
        {
            _components.Add(component);
        }

        public void Remove(IDocumentComponent component)
        {
            _components.Remove(component);
        }

        public void Display(int depth = 0)
        {
            Console.WriteLine(new string('-', depth) + Title);
            foreach (var component in _components)
            {
                component.Display(depth + 2);
            }
        }
    }
}
