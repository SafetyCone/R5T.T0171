using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0171
{
    /// <summary>
    /// The name of an instance variety.
    /// <para>Typed <basetype><see cref="string"/></basetype></para>
    /// </summary>
    [StrongTypeMarker]
    public interface IInstanceVarietyName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
