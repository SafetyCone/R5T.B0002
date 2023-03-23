using System;


namespace R5T.B0002.X001
{
    public partial class NamespaceNames
    {

#pragma warning disable CA1822 // Mark members as static

        [Obsolete("See R5T.Z0038.INamespaceNames.System")]
        public string System => "System";
        [Obsolete("See R5T.Z0038.INamespaceNames.System_IO")]
        public string System_IO => "System.IO";
        [Obsolete("See R5T.Z0038.INamespaceNames.System_Linq")]
        public string System_Linq => "System.Linq";
        [Obsolete("See R5T.Z0038.INamespaceNames.System_Threading")]
        public string System_Threading => "System.Threading";
        [Obsolete("See R5T.Z0038.INamespaceNames.System_Threading_Tasks")]
        public string System_Threading_Tasks => "System.Threading.Tasks";
    }
}
