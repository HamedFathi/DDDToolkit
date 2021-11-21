using System.Collections.Generic;

namespace DDDToolkit.Domain
{
    public interface IResult
    {
        bool Success { get; }
        IReadOnlyList<string> Messages { get; }
    }

    internal interface IConvertibleToResult : IResult
    {
        internal Result ParentResult { get; }
    }
}
