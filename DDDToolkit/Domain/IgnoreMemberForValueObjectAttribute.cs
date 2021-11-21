using System;

namespace DDDToolkit.Domain
{
    [AttributeUsage(AttributeTargets.Property)]
    public class IgnoreMemberForValueObjectAttribute : Attribute
    {
    }
}
