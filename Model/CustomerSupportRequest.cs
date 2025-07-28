namespace ChainOfResponsibility.Model
{
    public class CustomerSupportRequest
    {
        /// <summary>
        /// Unique identifier for the support request.
        /// </summary>
        public Guid RequestId { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Customer identifier.
        /// </summary>
        public string? CustomerId { get; set; }

        /// <summary>
        /// Customer name.
        /// </summary>
        public string? CustomerName { get; set; }

        /// <summary>
        /// Contact email for the customer.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Contact phone number for the customer.
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// Description of the support issue.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Date and time the request was created.
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Status of the support request.
        /// </summary>
        public SupportRequestStatus Status { get; set; } = SupportRequestStatus.New;
    }
}
