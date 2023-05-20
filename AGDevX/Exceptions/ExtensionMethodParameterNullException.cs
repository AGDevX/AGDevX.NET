using System;

namespace AGDevX.Exceptions;

/// <summary>
/// Exception to throw if a required parameter was not provided to an extension method
/// </summary>
public sealed class ExtensionMethodParameterNullException : CodedArgumentNullException
{
    public override string Code { get; set; } = "EXTENSION_METHOD_PARAMETER_NULL_EXCEPTION";

    public ExtensionMethodParameterNullException() : base()
    {
    }

    public ExtensionMethodParameterNullException(string argumentName) : base(argumentName)
    {
    }

    public ExtensionMethodParameterNullException(string argumentName, string code) : base(argumentName, code)
    {
        Code = code;
    }

    public ExtensionMethodParameterNullException(string message, Exception innerException) : base(message, innerException)
    {
    }

    public ExtensionMethodParameterNullException(string argumentName, string code, Exception innerException) : base(argumentName, code, innerException)
    {
        Code = code;
    }
}