using System;

using R5T.B0002;
using R5T.B0002.X001;


namespace System
{
    public static partial class INamespaceNameExtensions
    {
        /// <inheritdoc cref="NamespaceNames.AllNamespacesNamespaceName"/>
        [Obsolete("See R5T.Z0038.INamespaceNames.AllNamespaces")]
        public static string AllNamespacesNamespaceName(this INamespaceName _)
        {
            return NamespaceNames.Instance.AllNamespacesNamespaceName;
        }

        /// <inheritdoc cref="NamespaceNames.NoNamespacesNamespaceName"/>
        [Obsolete("See R5T.Z0038.INamespaceNames.NoNamespaces")]
        public static string NoNamespacesNamespaceName(this INamespaceName _)
        {
            return NamespaceNames.Instance.NoNamespacesNamespaceName;
        }
    }
}