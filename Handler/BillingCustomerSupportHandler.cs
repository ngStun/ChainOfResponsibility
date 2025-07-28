using ChainOfResponsibility.Model;

namespace ChainOfResponsibility.Handler
{
    /// <summary>
    /// Handles billing-related customer support requests.
    /// </summary>
    public class BillingCustomerSupportHandler : Handler<CustomerSupportRequest>
    {
        /// <summary>
        /// Handles the customer support request.
        /// Resolves requests containing "billing" in the description.
        /// </summary>
        /// <param name="request">The customer support request.</param>
        /// <returns>The status of the support request.</returns>
        public override async Task<object> HandleAsync(CustomerSupportRequest request)
        {
            Console.WriteLine("Handling billing customer support inquiry");

            if (request.Description != null && request.Description.Contains("billing"))
            {
                Console.WriteLine("Finished handling billing customer support inquiry");
                return SupportRequestStatus.Resolved;
            }

            Console.WriteLine("Unable to resolve billing inquiry, passing it onto another department");
            if (Next is null)
            {
                return SupportRequestStatus.Unresolved;
            }

            return await base.HandleAsync(request).ConfigureAwait(false);
        }
    }
}