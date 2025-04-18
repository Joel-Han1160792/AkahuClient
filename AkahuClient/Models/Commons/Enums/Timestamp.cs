using System.ComponentModel;

namespace AkahuClient.Models.Commons.Enums;

public enum Timestamp
{
    [Description("UTC Time Format (ISO 8601)")]
    UTC = 0,

    [Description("New Zealand Standard Time (NZST) UTC+12:00")]
    NZST = 12,

    [Description("New Zealand Daylight Time (NZDT) UTC+13:00")]
    NZDT = 13
}