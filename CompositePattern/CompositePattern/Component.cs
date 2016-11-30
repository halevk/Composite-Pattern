namespace CompositePattern
{
    public abstract class ComponentBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual decimal GetPrice()
        {
            return Price;
        }
    }
}