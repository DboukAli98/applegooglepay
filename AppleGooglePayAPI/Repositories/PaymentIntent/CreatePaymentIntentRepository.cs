using AppleGooglePayAPI.Interfaces.IRepositories.PaymentIntent;
using AppleGooglePayAPI.Models;
using AppleGooglePayAPI.Models.ResponseModels;
using Stripe;

namespace AppleGooglePayAPI.Repositories.PaymentIntent;

public class CreatePaymentIntentRepository : ICreatePaymentIntentRepository
{

    
    private readonly IConfiguration _configuration;
 
    
    public CreatePaymentIntentRepository(IConfiguration configuration )
    {
        _configuration = configuration;

    }
    
    public async Task<CreatePaymentIntentResponseModel> CreatePaymentIntent(string paymentType , string currency)
    {
        
        var options = new PaymentIntentCreateOptions()
        {
            Amount = 8000,
            Currency = currency,
            PaymentMethodTypes = new List<string>()
            {
                paymentType,
            },
        };
        
        var apiKey = _configuration["StripeAPITestKey"];
        var client = new StripeClient(apiKey);
        var service = new PaymentIntentService(client);
        var paymentIntent = await service.CreateAsync(options);
        return new CreatePaymentIntentResponseModel()
        {
            ClientSecret = paymentIntent.ClientSecret
        };


    }
}