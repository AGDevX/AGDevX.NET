using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using AGDevX.Exceptions;
using AGDevX.Strings;

namespace AGDevX.Assemblies;

public static class AssemblyUtility
{
    /// <summary>
    /// Recursively retrieves all assemblies referenced by the provided parent assembly or the currently executing assembly
    /// </summary>
    /// <remarks>
    /// Optionally provide a list of assembly prefixes to filter out all assemblies that do not begin with the prefixes
    /// </remarks>
    /// <param name="parent">The base assembly used to retrieve referenced assemblies (optional)</param>
    /// <param name="assemblyPrefixes">List of prefixes to filter out assemblies whose FullName does not begin with the prefixes (optional)</param>
    /// <returns>A list of assemblies referenced by the base assembly</returns>
    public static List<Assembly> GetAssemblies(Assembly? parent = default, IEnumerable<string>? assemblyPrefixes = default)
    {
        var referencedAssemblies = parent?.GetReferencedAssemblies().Select(a => Assembly.Load(a));
        var currentDomainAssemblies = AppDomain.CurrentDomain.GetAssemblies();
        assemblyPrefixes ??= Enumerable.Empty<string>();

        return (referencedAssemblies ?? currentDomainAssemblies)
            .Where(a => !assemblyPrefixes.Any() || a.FullNameStartsWithPrefixes(assemblyPrefixes))
            .SelectMany(a => GetAssemblies(a, assemblyPrefixes))
            .Concat(parent == null ? Enumerable.Empty<Assembly>() : new[] { parent })
            .Where(a => !assemblyPrefixes.Any() || a.FullNameStartsWithPrefixes(assemblyPrefixes))
            .Distinct()
            .ToList();
    }

    /// <summary>
    /// Determines if an assembly's FullName begins with any of the provided prefixes
    /// </summary>
    /// <param name="assemblyFullName">Assembly to check against (required)</param>
    /// <param name="assemblyPrefixes">List of prefixes that will be used to check the assembly's FullName against (required)</param>
    /// <returns>True if the assembly's FullName begins with any of the provided prefixes</returns>
    public static bool AssemblyNameStartsWithAnyPrefix([AllowNull] string assemblyFullName, [AllowNull] IEnumerable<string> assemblyPrefixes)
    {
        if (assemblyFullName == null)
        {
            throw new ExtensionMethodParameterNullException(nameof(assemblyFullName));
        }

        if (assemblyPrefixes == null)
        {
            throw new ExtensionMethodParameterNullException(nameof(assemblyPrefixes));
        }

        return !assemblyFullName.IsNullOrWhiteSpace()
            && assemblyPrefixes.Any(ap => assemblyFullName.StartsWithIgnoreCase(ap));
    }
}