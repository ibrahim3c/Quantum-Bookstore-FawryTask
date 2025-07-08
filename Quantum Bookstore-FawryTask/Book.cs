namespace Quantum_Bookstore_FawryTask
{
    internal abstract class Book
    {
        public string ISBN { get; }
        public string Title { get; }

        public DateTime PublishedDate { get; }

        public decimal Price { get; }

        protected Book(string iSBN, string title, DateTime publishedDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            PublishedDate = publishedDate;
            Price = price;
        }

        public bool IsOutdated(int years)
        {
            return (DateTime.Now.Year - PublishedDate.Year) >= years;
        }

        public abstract decimal BuyBook(IBuyingInfo BuyingInfo);

    }
    internal class PaperBook : Book
    {
        public PaperBook(string iSBN, string title, DateTime publishedDate, decimal price,int quantity) :base( iSBN,  title,  publishedDate,  price)
        {
         Quantity = quantity;   
        }
        public int Quantity { get; private set; }

        public override decimal BuyBook(IBuyingInfo BuyingInfo)
        {
            var info= BuyingInfo as BuyingPaperBookInfo;
            ReduceQunatity(info.Quantity);
            // Ship this book
            return this.Price;
        }

        public void ReduceQunatity(int quantity)
        {
            if(quantity > 0 && Quantity >= quantity)
                   Quantity-=quantity;
            else
                throw new Exception(" Out of Stock.");
        }
    }
    internal class EBook : Book
    {
        public EBook(string iSBN, string title, DateTime publishedDate, decimal price, string fileType) : base(iSBN, title, publishedDate, price)
        {
            FileType = fileType;
        }
        public string FileType {  get; }

        public override decimal BuyBook(IBuyingInfo BuyingInfo)
        {
            // sending this book using email service
            return this.Price;
        }
    }
    internal class DemoBook : Book
    {
        public DemoBook(string iSBN, string title, DateTime publishedDate, decimal price): base(iSBN, title, publishedDate, price)
        {
            
        }

        public override decimal BuyBook(IBuyingInfo BuyingInfo)
        {
                throw new Exception("This book is not for sale.");
        }
    }


}
