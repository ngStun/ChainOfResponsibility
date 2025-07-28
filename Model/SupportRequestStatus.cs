namespace ChainOfResponsibility.Model
{
    /// <summary>
    /// Status values for a support request.
    /// </summary>
    public enum SupportRequestStatus
    {
        New,
        InProgress,
        Resolved,
        Closed,
        Unresolved
    }
}
