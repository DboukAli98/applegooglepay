using AppleGooglePayAPI.Models.ResponseModels;

namespace AppleGooglePayAPI.Interfaces.IServices.PaymentIntent;

public interface ICreatePaymentIntentService
{
    Task<CreatePaymentIntentResponseModel> CreatePaymentIntent(string paymentType, string currency);
}