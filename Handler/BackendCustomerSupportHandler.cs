using ChainOfResponsibility.Model;

namespace ChainOfResponsibility.Handler
{
    /// <summary>
    /// Handles backend-related customer support requests.
    /// </summary>
    public class BackendCustomerSupportHandler : Handler<CustomerSupportRequest>
    {
        /// <summary>
        /// Handles the customer support request.
        /// Marks the request as in progress after a simulated delay.
        /// </summary>
        /// <param name="request">The customer support request.</param>
        /// <returns>The status of the support request.</returns>
        public override async Task<object> HandleAsync(CustomerSupportRequest request)
        {
            Console.WriteLine("Passing the customer support inquiry to dedicated backend support. They will reply within 1 business day.");
            await Task.Delay(500);
            return SupportRequestStatus.InProgress;
        }
    }
}