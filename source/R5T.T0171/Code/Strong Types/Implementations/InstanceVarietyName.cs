using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0171
{
    /// <inheritdoc cref="IInstanceVarietyName"/>
    [StrongTypeImplementationMarker]
    public class InstanceVarietyName : TypedBase<string>, IStrongTypeMarker,
        IInstanceVarietyName
    {
        public InstanceVarietyName(string value)
            : base(value)
        {
        }
    }
}
