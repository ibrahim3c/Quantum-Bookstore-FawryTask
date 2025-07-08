namespace Quantum_Bookstore_FawryTask
{
    internal interface IBuyingInfo
    {

    }

    internal class BuyingPaperBookInfo:IBuyingInfo
    {
        public int Quantity { get; set; }
        public string Address { get; set; }
    }

    internal class BuyingEBookInfo:IBuyingInfo
    {
        public int Quantity { get; set; }
        public string Email { get; set; }
    }

    internal class BuyingDemoBookInfo : IBuyingInfo
    {
    }



}
