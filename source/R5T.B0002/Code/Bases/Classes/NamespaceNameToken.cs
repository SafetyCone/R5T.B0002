using System;


namespace R5T.B0002
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class NamespaceNameToken : INamespaceNameToken
    {
        #region Static
        
        public static NamespaceNameToken Instance { get; } = new();

        #endregion
    }
}