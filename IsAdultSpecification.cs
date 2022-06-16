using System.Linq.Expressions;

namespace ef_core_specification_pattern;

public class IsAdultSpecification : Specification<User>
{
    public override Expression<Func<User, bool>> ToExpression()
    {
        return user => user.Age > 20;
    }
}
