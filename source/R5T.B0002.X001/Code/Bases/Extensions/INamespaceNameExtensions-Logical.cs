using System;

using R5T.B0002;
using R5T.B0002.X001;


namespace System
{
    public static partial class INamespaceNameExtensions
    {
        /// <inheritdoc cref="NamespaceNames.AllNamespacesNamespaceName"/>
        public static string AllNamespacesNamespaceName(this INamespaceName _)
        {
            return NamespaceNames.Instance.AllNamespacesNamespaceName;
        }

        /// <inheritdoc cref="NamespaceNames.NoNamespacesNamespaceName"/>
        public static string NoNamespacesNamespaceName(this INamespaceName _)
        {
            return NamespaceNames.Instance.NoNamespacesNamespaceName;
        }
    }
}