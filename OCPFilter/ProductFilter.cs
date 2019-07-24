using System.Collections.Generic;
using System.Linq;

namespace OCPFilter
{
    public class ProductFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> products, ISpecification<Product> specification)
        {
            return products.Where(specification.IsSatisfied);
        }
    }
}
