using System.Linq.Expressions;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
        int Take { get; } // ** (page 1: Take 5, page 2: Take 5)
        int Skip { get; } // ** (page 1: Skip 0, page 2: Skip 5)
        bool IsPagingEnabled { get; }
    }
}