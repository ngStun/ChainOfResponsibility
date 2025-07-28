using ChainOfResponsibility.Model;

namespace ChainOfResponsibility.Handler
{
    /// <summary>
    /// Handles general customer support requests.
    /// </summary>
    public class GeneralCustomerSupportHandler : Handler<CustomerSupportRequest>
    {
        /// <summary>
        /// Handles the customer support request.
        /// Resolves requests containing "general" in the description.
        /// </summary>
        /// <param name="request">The customer support request.</param>
        /// <returns>The status of the support request.</returns>
        public override async Task<object> HandleAsync(CustomerSupportRequest request)
        {
            Console.WriteLine("Handling general customer support inquiry");

            if (request.Description != null && request.Description.Contains("general"))
            {
                Console.WriteLine("Finished handling general customer support inquiry");
                return SupportRequestStatus.Resolved;
            }

            Console.WriteLine("Unable to resolve general support inquiry, passing it onto another department");
            if (Next is null)
            {
                return SupportRequestStatus.Unresolved;
            }

            return await base.HandleAsync(request).ConfigureAwait(false);
        }
    }
}