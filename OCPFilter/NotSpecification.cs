using System;

namespace OCPFilter
{
    class NotSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> product;

        public NotSpecification(ISpecification<T> product)
        {
            this.product = product ?? throw new ArgumentNullException(paramName: nameof(product));
        }

        public bool IsSatisfied(Product product)
        {
            return ! this.product.IsSatisfied(product);
        }
    }
}
