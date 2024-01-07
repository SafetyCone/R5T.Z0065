using System;

using R5T.T0131;
using R5T.T0228;
using R5T.T0228.Extensions;


namespace R5T.Z0065.Z001
{
    [ValuesMarker]
    public partial interface INamespaceNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Z000.INamespaceNames _StringlyTyped => Z000.NamespaceNames.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Z000.INamespaceNames.Microsoft_CodeAnalysis"/>
        public INamespaceName Microsoft_CodeAnalysis => _StringlyTyped.Microsoft_CodeAnalysis.ToNamespaceName();

        /// <inheritdoc cref="Z000.INamespaceNames.Microsoft_CodeAnalysis_CSharp"/>
        public INamespaceName Microsoft_CodeAnalysis_CSharp => _StringlyTyped.Microsoft_CodeAnalysis_CSharp.ToNamespaceName();

        /// <inheritdoc cref="Z000.INamespaceNames.Microsoft_CodeAnalysis_CSharp_Syntax"/>
        public INamespaceName Microsoft_CodeAnalysis_CSharp_Syntax => _StringlyTyped.Microsoft_CodeAnalysis_CSharp_Syntax.ToNamespaceName();

        /// <inheritdoc cref="Z000.INamespaceNames.Microsoft_Extensions_Configuration"/>
        public INamespaceName Microsoft_Extensions_Configuration => _StringlyTyped.Microsoft_Extensions_Configuration.ToNamespaceName();

        /// <inheritdoc cref="Z000.INamespaceNames.Microsoft_Extensions_DependencyInjection"/>
        public INamespaceName Microsoft_Extensions_DependencyInjection => _StringlyTyped.Microsoft_Extensions_DependencyInjection.ToNamespaceName();

        /// <inheritdoc cref="Z000.INamespaceNames.Microsoft_Extensions_Hosting"/>
        public INamespaceName Microsoft_Extensions_Hosting => _StringlyTyped.Microsoft_Extensions_Hosting.ToNamespaceName();

        /// <inheritdoc cref="Z000.INamespaceNames.Microsoft_Extensions_Logging"/>
        public INamespaceName Microsoft_Extensions_Logging => _StringlyTyped.Microsoft_Extensions_Logging.ToNamespaceName();
    }
}
