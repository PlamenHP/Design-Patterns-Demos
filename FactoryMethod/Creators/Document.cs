namespace FactoryMethod.Creators
{
    using Products;
    using System.Collections.Generic;

    abstract class Document
    {
        private List<Page> pages = new List<Page>();

        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return pages; }
        }

        public abstract void CreatePages();
    }
}
