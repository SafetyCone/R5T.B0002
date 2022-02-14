using System;


namespace R5T.B0002
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class NamespaceNameOperator : INamespaceNameOperator
    {
        #region Static
        
        public static NamespaceNameOperator Instance { get; } = new();

        #endregion
    }
}