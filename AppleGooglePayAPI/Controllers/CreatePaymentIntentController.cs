using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppleGooglePayAPI.Interfaces.IServices.PaymentIntent;
using AppleGooglePayAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppleGooglePayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreatePaymentIntentController : ControllerBase
    {
        private readonly ICreatePaymentIntentService _createPaymentIntentService;

        public CreatePaymentIntentController(ICreatePaymentIntentService createPaymentIntentService)
        {
            _createPaymentIntentService = createPaymentIntentService;
        }

        [Route("create-payment-intent")]
        [HttpPost]
        public async Task<IActionResult> CreatePaymentIntent([FromBody] CreatePaymentIntentRequest model)
        {
            var result = await _createPaymentIntentService.CreatePaymentIntent(model.PaymentMethodType, model.Currency);
            return Ok(result);
        }
    }
}
