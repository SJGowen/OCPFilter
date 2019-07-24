namespace OCPFilter
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(Product product);
    }
}
