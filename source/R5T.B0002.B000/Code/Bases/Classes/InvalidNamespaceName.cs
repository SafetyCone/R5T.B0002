using System;


namespace R5T.B0002.B000
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class InvalidNamespaceName : IInvalidNamespaceName
    {
        #region Static
        
        public static InvalidNamespaceName Instance { get; } = new();

        #endregion
    }
}