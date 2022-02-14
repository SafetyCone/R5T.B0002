using System;

using Strings = R5T.B0000.X001.Strings;


namespace R5T.B0002.X002
{
    /// <summary>
    /// <inheritdoc cref="Y0000.Documentation.ForNamespaceName.InvalidNamespaceName" path="/definition"/>
    /// </summary>
    public static partial class NamespaceNames_Invalid
    {
        public static string Empty => Strings.Empty;

        public static string StartsWithANumber => "2R5T";
        public static string StartsWithNumbers => "22R5T";

        public static string VerbatimSpecifierOnly => "@";
        public static string NonLeadingVerbatimSpecifier => "R@";

        public static string UnescapedKeyword => "string";
    }
}
