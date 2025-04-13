using System.ComponentModel;

namespace AkahuClient.Models.Accounts.Enums;

public enum AccountStatus
{
    [Description("INACTIVE")]
    Inactive,
    [Description("ACTIVE")]
    Active,
}