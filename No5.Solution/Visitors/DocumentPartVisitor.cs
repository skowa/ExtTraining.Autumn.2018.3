using No5.Solution.DocumentParts;

namespace No5.Solution.Visitors
{
    public abstract class DocumentPartVisitor
    {
        public string Visit(DocumentPart documentPart) => Visit((dynamic) documentPart);

        protected abstract string Visit(BoldText boldText);
        protected abstract string Visit(HyperLink hyperLink);
        protected abstract string Visit(PlainText plainText);
    }
}