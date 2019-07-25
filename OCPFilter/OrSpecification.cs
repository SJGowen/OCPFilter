using System;

namespace OCPFilter
{
    class OrSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> first;
        private readonly ISpecification<T> second;

        public OrSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
            this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
        }

        public bool IsSatisfied(Product product)
        {
            return first.IsSatisfied(product) || second.IsSatisfied(product);
        }
    }
}
