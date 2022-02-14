using System;

using R5T.B0002;

using Instances = R5T.B0002.X001.Instances;


namespace System
{
    public static partial class INamespaceNameOperatorExtensions
    {
        public static bool IsInMicrosoft(this INamespaceNameOperator _,
            string namespaceName)
        {
            var output = _.IsInNamespace(
                namespaceName,
                Instances.NamespaceName.Microsoft());

            return output;
        }

        public static bool IsInSystem(this INamespaceNameOperator _,
            string namespaceName)
        {
            var output = _.IsInNamespace(
                namespaceName,
                Instances.NamespaceName.System());

            return output;
        }
    }
}
