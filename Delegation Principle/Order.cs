namespace Delegation_Principle
{
    public class Order
    {
        public int Price { get; set; }
        public int valueAddedTax { get; set; }
        public int total => Price + valueAddedTax;
    }
}
