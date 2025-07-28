using ChainOfResponsibility.Model;

namespace ChainOfResponsibility.Handler
{
    /// <summary>
    /// Handles account-related customer support requests.
    /// </summary>
    public class AccountCustomerSupportHandler : Handler<CustomerSupportRequest>
    {
        /// <summary>
        /// Handles the customer support request.
        /// Resolves requests containing "account" in the description.
        /// </summary>
        /// <param name="request">The customer support request.</param>
        /// <returns>The status of the support request.</returns>
        public override async Task<object> HandleAsync(CustomerSupportRequest request)
        {
            Console.WriteLine("Handling account related customer support inquiry");

            if (request.Description != null && request.Description.Contains("account"))
            {
                Console.WriteLine("Finished handling account related customer support inquiry");
                return SupportRequestStatus.Resolved;
            }

            Console.WriteLine("Unable to resolve customer account support inquiry, passing it onto another department");
            if (Next is null)
            {
                return SupportRequestStatus.Unresolved;
            }

            return await base.HandleAsync(request).ConfigureAwait(false);
        }
    }
}