using System;

using R5T.T0131;


namespace R5T.B0002.X001
{
    public partial class NamespaceNames
    {

#pragma warning disable CA1822 // Mark members as static

        /// <summary>
        /// ALL namespaces are contained within the namespace with this name.
        /// As in, all of "System", "global::System", "R5T", extern alias DependencyX -> "DependencyX::System" are contained within "".
        /// </summary>
        [Obsolete("See R5T.Z0038.INamespaceNames.AllNamespaces")]
        public string AllNamespacesNamespaceName => "";
        /// <summary>
        /// No namespaces are contained within the namespace with this name.
        /// No matter was namespace name you can dream up, the result of ContainsNamespace(parentNamespaceName, childNamespaceName) will be false of the parent has this namespace name.
        /// </summary>
        [Obsolete("See R5T.Z0038.INamespaceNames.NoNamespaces")]
        public string NoNamespacesNamespaceName => null;
    }
}
