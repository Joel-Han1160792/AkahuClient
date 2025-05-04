namespace AkahuClient.Models.Payments;

public enum PaymentStatusCode
{
    InternalError,
    BankError,
    Unavailable,
    InvalidAccount,
    InsufficientFunds,
    SingleLimitExceeded,
    DailyLimitExceeded,
    AkahuLimitExceeded,
    MfaUnsupported,
    MultisigUnsupported,
    AuthenticationFailed,
    MfaFailed,
    AfterHours,
    UserCancelled,
    AppCancelled,
    AkahuCancelled
}