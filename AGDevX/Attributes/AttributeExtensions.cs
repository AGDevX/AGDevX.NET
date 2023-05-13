using System.ComponentModel;
using AGDevX.Exceptions;
using AGDevX.IEnumerables;

namespace AGDevX.Attributes;

public static class AttributeExtensions
{
    /// <summary>
    /// Retrieves the value of the DescriptionAttribute for an objects of type T
    /// </summary>
    /// <typeparam name="T">Any type that supports a DescriptionAttribute</typeparam>
    /// <param name="obj">Object for which to retrieve the value of the DescriptionAttribute (required)</param>
    /// <param name="searchInheritanceChain">Determines whether or not to search the members inheritance chain for the attribute (required)</param>
    /// <returns>The value of the DescriptionAttribute if the value can be retrieved. Otherwise, null.</returns>
    /// <exception cref="ExtensionMethodParameterNullException">Thrown if a required parameter was not provided</exception>
    /// <exception cref="ExtensionMethodException">Thrown if the object's FieldInfo could not be retrieved</exception>
    public static string? GetDescription<T>(this T obj, bool searchInheritanceChain = true)
    {
        if (obj == null || obj.ToString() == null)
        {
            throw new ExtensionMethodParameterNullException($"The provided { nameof(obj) } argument was null");
        }

        var fieldInfo = obj.GetType().GetField(obj.ToString()!) 
                            ?? throw new ExtensionMethodException($"Unable to get Field Info");

        var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), searchInheritanceChain);

        if (descriptionAttributes.AnySafe())
        {
            return descriptionAttributes[0].Description;
        }
        else
        {
            return null;
        }
    }
}