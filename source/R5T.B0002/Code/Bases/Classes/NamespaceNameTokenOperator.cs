using System;


namespace R5T.B0002
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class NamespaceNameTokenOperator : INamespaceNameTokenOperator
    {
        #region Static
        
        public static NamespaceNameTokenOperator Instance { get; } = new();

        #endregion
    }
}