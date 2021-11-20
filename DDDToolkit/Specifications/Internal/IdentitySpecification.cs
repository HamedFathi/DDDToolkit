using DDDToolkit.Specifications;
using System;
using System.Linq.Expressions;

namespace DDDToolkit.Specifications.Internal
{
    internal sealed class IdentitySpecification<T> : Specification<T>
    {
        public override Expression<Func<T, bool>> ToExpression()
            => _ => true;
    }
}
