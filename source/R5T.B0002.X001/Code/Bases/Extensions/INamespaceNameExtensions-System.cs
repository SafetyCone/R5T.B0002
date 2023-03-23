using System;

using R5T.B0002;
using R5T.B0002.X001;


namespace System
{
    public static partial class INamespaceNameExtensions
    {
        [Obsolete("See R5T.Z0038.INamespaceNames.System")]
        public static string System(this INamespaceName _)
        {
            return NamespaceNames.Instance.System;
        }

        [Obsolete("See R5T.Z0038.INamespaceNames.System_IO")]
        public static string System_IO(this INamespaceName _)
        {
            return NamespaceNames.Instance.System_IO;
        }

        [Obsolete("See R5T.Z0038.INamespaceNames.System_Linq")]
        public static string System_Linq(this INamespaceName _)
        {
            return NamespaceNames.Instance.System_Linq;
        }

        [Obsolete("See R5T.Z0038.INamespaceNames.System_Threading")]
        public static string System_Threading(this INamespaceName _)
        {
            return NamespaceNames.Instance.System_Threading;
        }

        [Obsolete("See R5T.Z0038.INamespaceNames.System_Threading_Tasks")]
        public static string System_Threading_Tasks(this INamespaceName _)
        {
            return NamespaceNames.Instance.System_Threading_Tasks;
        }
    }
}