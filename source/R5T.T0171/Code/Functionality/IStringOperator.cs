using System;

using R5T.T0132;


namespace R5T.T0171
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public InstanceVarietyName ToInstanceVarietyName(string value)
        {
            var output = new InstanceVarietyName(value);
            return output;
        }
    }
}
