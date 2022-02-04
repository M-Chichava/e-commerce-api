using System.Linq.Expressions;
using System;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria {get;} 
        List<Expression<Func<T, object>>> Includes {get;}
        Expression<Func<T, Object>> OrderBy {get;}
        Expression<Func<T, Object>> OrderByDescending {get;}
    }
}