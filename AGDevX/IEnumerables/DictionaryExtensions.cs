using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using AGDevX.Exceptions;

namespace AGDevX.IEnumerables;

public static class DictionaryExtensions
{
#pragma warning disable CS8714 // The type cannot be used as type parameter in the generic type or method. Nullability of type argument doesn't match 'notnull' constraint.

    /// <summary>
    /// Switches the place of the Dictionary's Keys and Values
    /// </summary>
    /// <typeparam name="TKey">Type of the Key of the dictionary</typeparam>
    /// <typeparam name="TValue">Type of the Value of the dictionary</typeparam>
    /// <param name="dictionary">Dictionary for which to switch the place of Keys and Values (required)</param>
    /// <returns>Dictionary with the Keys and Values switched</returns>
    /// <exception cref="ExtensionMethodParameterNullException">Thrown if either of the required Dictionaries is null</exception>
    public static Dictionary<TValue, TKey> ReverseKeysAndValues<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
    {
        return dictionary.ToDictionary(x => x.Value, x => x.Key);
    }

    /// <summary>
    /// Appends one Dictionary to another
    /// </summary>
    /// <typeparam name="TKey">Type of the Key of the dictionary</typeparam>
    /// <typeparam name="TValue">Type of the Value of the dictionary</typeparam>
    /// <param name="dictionary1">Dictionary 1 to be conbined with Dictionary 2 (required)</param>
    /// <param name="dictionary2">Dictionary 2 to be conbined with Dictionary 1 (required)</param>
    /// <returns>The concatenated Dictionaries</returns>
    /// <exception cref="ExtensionMethodParameterNullException">Thrown if either of the required Dictionaries is null</exception>
    public static Dictionary<TKey, TValue> Concatenate<TKey, TValue>(this Dictionary<TKey, TValue> dictionary1, [AllowNull] Dictionary<TKey, TValue> dictionary2)
    {
        if (dictionary2 == null)
        {
            throw new ExtensionMethodParameterNullException(nameof(dictionary2));
        }

        return dictionary1.Concat(dictionary2).ToDictionary(x => x.Key, x => x.Value);
    }

#pragma warning restore CS8714 // The type cannot be used as type parameter in the generic type or method. Nullability of type argument doesn't match 'notnull' constraint.
}