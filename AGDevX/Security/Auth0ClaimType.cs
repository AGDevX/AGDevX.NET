using System.ComponentModel;
using AGDevX.Enums;

namespace AGDevX.Security;

/// <summary>
/// Claim Types as defined by Auth0
/// </summary>
public enum Auth0ClaimType
{
    [Description("gty")]
    [EnumStringValue("gty")]
    GrantType = 1
}