using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0171
{
    /// <summary>
    /// The name of an instance variety.
    /// </summary>
    [StrongTypeMarker]
    public class InstanceVarietyName : TypedString, IStrongTypeMarker
    {
        public InstanceVarietyName(string value)
            : base(value)
        {
        }
    }
}
