﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using AGDevX.Exceptions;
using AGDevX.Strings;

namespace AGDevX.Assemblies;

public static class AssemblyExtensions
{
    /// <summary>
    /// Determines if an assembly's FullName begins with the provided string prefix
    /// </summary>
    /// <param name="assembly">Assembly to check against (required)</param>
    /// <param name="prefix">Prefix to check (required)</param>
    /// <returns>True if the assembly's FullName beings with the provided string prefix. Otherwise, false.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the provided assembly's FullName is null</exception>
    public static bool FullNameStartsWithPrefix(this Assembly assembly, [AllowNull] string prefix)
    {
        if (prefix == null)
        {
            throw new ExtensionMethodParameterNullException(nameof(prefix));
        }

        return assembly.FullName?.StartsWithIgnoreCase(prefix) ?? throw new ArgumentNullException($"The provided {nameof(assembly)} FullName was null");
    }

    /// <summary>
    /// Determines if an assembly's FullName begins with any of the provided string prefixes
    /// </summary>
    /// <param name="assembly">Assembly to check against (required)</param>
    /// <param name="prefixes">Prefixes to check (required)</param>
    /// <returns>True if the assembly's FullName beings with any of the provided string prefixes. Otherwise, false.</returns>
    public static bool FullNameStartsWithPrefixes(this Assembly assembly, [AllowNull] IEnumerable<string> prefixes)
    {
        if (prefixes == null)
        {
            throw new ExtensionMethodParameterNullException(nameof(prefixes));
        }

        return prefixes.Any(p => FullNameStartsWithPrefix(assembly, p));
    }
}