using AppleGooglePayAPI.Models.ResponseModels;

namespace AppleGooglePayAPI.Interfaces.IRepositories.PaymentIntent;

public interface ICreatePaymentIntentRepository
{
    Task<CreatePaymentIntentResponseModel> CreatePaymentIntent(string paymentType, string currency);
}