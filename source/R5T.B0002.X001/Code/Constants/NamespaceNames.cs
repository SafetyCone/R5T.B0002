using System;

using R5T.T0131;


namespace R5T.B0002.X001
{
    [ConstantsMarker]
    public partial class NamespaceNames : IConstantsMarker
    {
        #region Infrastructure

        public static NamespaceNames Instance { get; } = new();

        private NamespaceNames()
        {
        }

        #endregion
    }
}
