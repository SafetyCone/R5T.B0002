using System;

using R5T.B0000;


namespace R5T.B0002.X001
{
    public static class Instances
    {
        public static ICharacter Character { get; } = B0000.Character.Instance;
        public static INamespaceName NamespaceName { get; } = B0002.NamespaceName.Instance;
        public static IString String { get; } = B0000.String.Instance;
        public static IStringOperator StringOperator { get; } = B0000.StringOperator.Instance;
    }
}
