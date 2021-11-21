using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
namespace DDDToolkit.Domain
{


    /// <summary>
    /// <see cref="https://enterprisecraftsmanship.com/posts/value-object-better-implementation/"/>
    /// </summary>
    public abstract class ValueObject2<T>
        where T : ValueObject2<T>
    {
        protected virtual IEnumerable<object> GetEqualityComponents()
        {
            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(prop => !Attribute.IsDefined(prop, typeof(IgnoreMemberForValueObjectAttribute)));

            foreach (var prop in props)
            {
                yield return prop.GetValue(this, null);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            var valueObject = (ValueObject2<T>)obj;

            return GetEqualityComponents().SequenceEqual(valueObject.GetEqualityComponents());
        }

        public override int GetHashCode()
        {
            return GetEqualityComponents()
                .Aggregate(1, (current, obj) =>
                {
                    unchecked
                    {
                        return current * 23 + (obj?.GetHashCode() ?? 0);
                    }
                });
        }

        public static bool operator ==(ValueObject2<T> a, ValueObject2<T> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(ValueObject2<T> a, ValueObject2<T> b)
        {
            return !(a == b);
        }
    }
}
