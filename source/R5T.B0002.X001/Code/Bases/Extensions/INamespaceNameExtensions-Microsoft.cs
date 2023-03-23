using System;

using R5T.B0002;
using R5T.B0002.X001;


namespace System
{
    public static partial class INamespaceNameExtensions
    {
        [Obsolete("See R5T.Z0038.INamespaceNames.Microsoft")]
        public static string Microsoft(this INamespaceName _)
        {
            return NamespaceNames.Instance.Microsoft;
        }

        [Obsolete("See R5T.Z0038.INamespaceNames.Microsoft_Extensions")]
        public static string Microsoft_Extensions(this INamespaceName _)
        {
            return NamespaceNames.Instance.Microsoft_Extensions;
        }

        [Obsolete("See R5T.Z0038.INamespaceNames.Microsoft_Extensions_Configuration")]
        public static string Microsoft_Extensions_Configuration(this INamespaceName _)
        {
            return NamespaceNames.Instance.Microsoft_Extensions_Configuration;
        }

        [Obsolete("See R5T.Z0038.INamespaceNames.Microsoft_Extensions_DependencyInjection")]
        public static string Microsoft_Extensions_DependencyInjection(this INamespaceName _)
        {
            return NamespaceNames.Instance.Microsoft_Extensions_DependencyInjection;
        }

        [Obsolete("See R5T.Z0038.INamespaceNames.Microsoft_Extensions_Hosting")]
        public static string Microsoft_Extensions_Hosting(this INamespaceName _)
        {
            return NamespaceNames.Instance.Microsoft_Extensions_Hosting;
        }

        [Obsolete("See R5T.Z0038.INamespaceNames.Microsoft_Extensions_Logging")]
        public static string Microsoft_Extensions_Logging(this INamespaceName _)
        {
            return NamespaceNames.Instance.Microsoft_Extensions_Logging;
        }
    }
}