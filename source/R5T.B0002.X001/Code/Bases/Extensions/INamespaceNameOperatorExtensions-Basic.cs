using System;
using System.Collections.Generic;
using System.Linq;

using R5T.B0002;

using Instances = R5T.B0002.X001.Instances;


namespace System
{
    public static partial class INamespaceNameOperatorExtensions
    {
        /// <summary>
        /// Chooses <see cref="AppendTokenWithSeparator(INamespaceNameOperator, string, string)"/> as the default.
        /// </summary>
        public static string AppendToken(this INamespaceNameOperator _,
            string baseNamespaceName,
            string namespaceNameToken)
        {
            var output = _.AppendTokenWithSeparator(
                baseNamespaceName,
                namespaceNameToken);

            return output;
        }

        public static string AppendTokenWithSeparator(this INamespaceNameOperator _,
            string baseNamespaceName,
            string namespaceNameToken)
        {
            var output = Instances.StringOperator.AppendWithSeparator(
                baseNamespaceName,
                _.TokenSeparator_Character(),
                namespaceNameToken);

            return output;
        }

        public static string AppendTokenWithoutSeparator(this INamespaceNameOperator _,
            string baseNamespaceName,
            string namespaceNameToken)
        {
            var output = Instances.StringOperator.Append(
                baseNamespaceName,
                namespaceNameToken);

            return output;
        }

        public static string CombineTokens(this INamespaceNameOperator _,
            IEnumerable<string> namespaceNameTokens)
        {
            var output = Instances.StringOperator.Join(
                _.TokenSeparator_Character(),
                namespaceNameTokens);

            return output;
        }

        /// <summary>
        /// Enumerates the namespace and all sub-namespaces in a namespace.
        /// For example: R5T.T0064.X001 => {R5T.T0064.X001, R5T.T0064, R5T }.
        /// </summary>
        public static IEnumerable<string> EnumerateNamespaceAndSubNamespaces(this INamespaceNameOperator _,
            string namespaceName)
        {
            var currentNamespace = namespaceName;

            yield return currentNamespace;

            var hasLastindexOfTokenSeparator = Instances.StringOperator.HasLastIndexOf(_.TokenSeparator_Character(),
                currentNamespace);

            while (hasLastindexOfTokenSeparator)
            {
                var subNamespace = Instances.StringOperator.BeginningUpToButNotIncluding(hasLastindexOfTokenSeparator.Result,
                    currentNamespace);

                yield return subNamespace;

                currentNamespace = subNamespace;

                hasLastindexOfTokenSeparator = Instances.StringOperator.HasLastIndexOf(_.TokenSeparator_Character(),
                    currentNamespace);
            }
        }

        public static string GetLastToken(this INamespaceNameOperator _,
            string namespaceName)
        {
            var tokens = _.Tokenize(namespaceName);

            var output = tokens.Last();
            return output;
        }

        public static string[] GetTokens(this INamespaceNameOperator _,
            string namespaceName)
        {
            var output = _.Tokenize(namespaceName);
            return output;
        }

        /// <summary>
        /// Tests the the <paramref name="namespaceName"/> is in the <paramref name="baseNamespaceName"/>.
        /// </summary>
        public static bool IsInNamespace(this INamespaceNameOperator _,
            string namespaceName,
            string baseNamespaceName)
        {
            var isAtLeastTheSameLength = Instances.StringOperator.IsAtLeastTheSameLength(
                namespaceName,
                baseNamespaceName);

            if (!isAtLeastTheSameLength)
            {
                return false;
            }

            var output = Instances.StringOperator.StartsWith(
                namespaceName,
                baseNamespaceName);

            return output;
        }

        public static bool IsOutsideNamespace(this INamespaceNameOperator _,
            string namespaceName,
            string baseNamespaceName)
        {
            var isInNamespace = _.IsInNamespace(
                namespaceName,
                baseNamespaceName);

            var output = !isInNamespace;
            return output;
        }

        public static bool IsSameNamespaceName(this INamespaceNameOperator _,
            string namespaceName1,
            string namespaceName2)
        {
            var output = namespaceName1 == namespaceName2;
            return output;
        }

        public static string[] Tokenize(this INamespaceNameOperator _,
            string namespaceName)
        {
            // There should be no empty entries, so allow them to stay since this should cause problems that will then have to be addressed: why do you have empty tokens in your namespace name?
            var output = Instances.StringOperator.Split(
                namespaceName,
                _.TokenSeparator_Character());

            return output;
        }

        public static string TokenSeparator(this INamespaceNameOperator _)
        {
            var output = Instances.String.Period();
            return output;
        }

        public static char TokenSeparator_Character(this INamespaceNameOperator _)
        {
            var output = Instances.Character.Period();
            return output;
        }
    }
}
