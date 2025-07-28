// See https://aka.ms/new-console-template for more information

using ChainOfResponsibility.Handler;
using ChainOfResponsibility.Model;

var messages =
    new List<string>
    {
        "Unable to access account dashboard",
        "Unable to login into account",
        "Needs help with billing",
        "Needs information about general promotions",
        "Need help with refund"
    };

var random = new Random();
int index = random.Next(messages.Count);
var message = messages[index];

Console.WriteLine("Customer inquiry: {0}", message);

var supportRequest = new CustomerSupportRequest
{
    CustomerId = "CUST12345",
    CustomerName = "Jane Doe",
    Email = "jane.doe@example.com",
    Phone = "+1-555-1234",
    Description = message,
    CreatedDate = DateTime.UtcNow,
    Status = SupportRequestStatus.New
};

var handler = new GeneralCustomerSupportHandler();

handler.SetNext(new BillingCustomerSupportHandler())
.SetNext(new AccountCustomerSupportHandler())
.SetNext(new BackendCustomerSupportHandler());

var result = await handler.HandleAsync(supportRequest).ConfigureAwait(false);

Console.WriteLine(result);