using System;


namespace R5T.T0171.Extensions
{
    public static class StringExtensions
    {
        public static InstanceVarietyName ToInstanceVarietyName(this string value)
        {
            var output = Instances.StringOperator.ToInstanceVarietyName(value);
            return output;
        }
    }
}
