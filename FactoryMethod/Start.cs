namespace FactoryMethod
{
    using Creators;
    using Products;

    class Start
    {
        static void Main(string[] args)
        {
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            foreach (Document document in documents)
            {
                System.Console.WriteLine("\n" + document.GetType().Name+ "--");

                foreach (Page page in document.Pages)
                {
                    System.Console.WriteLine(" " + page.GetType().Name);
                }
            }
        }
    }  
}
