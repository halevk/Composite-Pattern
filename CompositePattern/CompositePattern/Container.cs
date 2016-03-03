using System.Collections.Generic;

namespace CompositePattern
{
    public abstract class Container : Component
    {
        protected List<Component> _Components = new List<Component>();

        protected Container(string name, int price)
            : base(name, price)
        {

        }

        public void Add(Component component)
        {
            _Components.Add(component);
        }

        public override int Price
        {
            get
            {
                int totalPrice = _price;
                foreach (var component in _Components)
                {
                    totalPrice += component.Price;
                }
                return totalPrice;
            }
        }
    }
}