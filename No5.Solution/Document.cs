using System;
using System.Collections.Generic;
using No5.Solution.DocumentParts;
using No5.Solution.Visitors;

namespace No5.Solution
{
    public class Document
    {
        private readonly List<DocumentPart> parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }

            this.parts = new List<DocumentPart>(parts);
        }

        public string ToHtml() => ToExactType(p => p.ToHtml());

        public string ToPlainText() => ToExactType(p => p.ToPlainText());

        public string ToLaTeX() => ToExactType(p => p.ToLaTeX());

        public string ToVisitorType(DocumentPartVisitor visitor)
        {
            return ToExactType(p => visitor.Visit(p));
        }

        private string ToExactType(Func<DocumentPart, string> convertRule)
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += $"{convertRule(part)}\n";
            }

            return output;
        }
    }
}