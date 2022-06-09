using System;

using R5T.B0002;
using R5T.B0002.X001;


namespace System
{
    public static partial class INamespaceNameExtensions
    {
        public static string System(this INamespaceName _)
        {
            return NamespaceNames.Instance.System;
        }

        public static string System_IO(this INamespaceName _)
        {
            return NamespaceNames.Instance.System_IO;
        }

        public static string System_Linq(this INamespaceName _)
        {
            return NamespaceNames.Instance.System_Linq;
        }

        public static string System_Threading(this INamespaceName _)
        {
            return NamespaceNames.Instance.System_Threading;
        }

        public static string System_Threading_Tasks(this INamespaceName _)
        {
            return NamespaceNames.Instance.System_Threading_Tasks;
        }
    }
}