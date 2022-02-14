using System;


namespace R5T.B0002.B000
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class RecommendedNamespaceName : IRecommendedNamespaceName
    {
        #region Static
        
        public static RecommendedNamespaceName Instance { get; } = new();

        #endregion
    }
}