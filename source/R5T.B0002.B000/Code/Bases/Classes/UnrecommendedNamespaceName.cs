using System;


namespace R5T.B0002.B000
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class UnrecommendedNamespaceName : IUnrecommendedNamespaceName
    {
        #region Static
        
        public static UnrecommendedNamespaceName Instance { get; } = new();

        #endregion
    }
}