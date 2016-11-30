using System.Collections.Generic;

namespace CompositePattern
{
    public abstract class ContainerBase : ComponentBase
    {
        protected List<ComponentBase> Components;

        protected ContainerBase()
        {
            Components=new List<ComponentBase>();
        }

        public void Add(ComponentBase component)
        {
            Components.Add(component);
        }
    }
}