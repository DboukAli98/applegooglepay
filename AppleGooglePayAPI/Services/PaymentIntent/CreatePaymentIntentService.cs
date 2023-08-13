using AppleGooglePayAPI.Interfaces.IRepositories.PaymentIntent;
using AppleGooglePayAPI.Interfaces.IServices.PaymentIntent;
using AppleGooglePayAPI.Models.ResponseModels;

namespace AppleGooglePayAPI.Services.PaymentIntent;

public class CreatePaymentIntentService : ICreatePaymentIntentService
{
    private readonly ICreatePaymentIntentRepository _createPaymentIntentRepository;

    public CreatePaymentIntentService(ICreatePaymentIntentRepository createPaymentIntentRepository)
    {
        _createPaymentIntentRepository = createPaymentIntentRepository;
    }

    public async Task<CreatePaymentIntentResponseModel> CreatePaymentIntent(string paymentType, string currency)
    {
        return await _createPaymentIntentRepository.CreatePaymentIntent(paymentType, currency);
    }

}