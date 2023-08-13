using AppleGooglePayAPI;
using AppleGooglePayAPI.Interfaces.IRepositories.PaymentIntent;
using AppleGooglePayAPI.Interfaces.IServices.PaymentIntent;
using AppleGooglePayAPI.Repositories.PaymentIntent;
using AppleGooglePayAPI.Services.PaymentIntent;
using Stripe;





var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        policyBuilder => policyBuilder
            .WithOrigins("https://rltdbodev.netlify.app")
            .AllowAnyHeader()
            .AllowAnyMethod()

    );
});


builder.Services.AddScoped<ICreatePaymentIntentRepository, CreatePaymentIntentRepository>();
builder.Services.AddScoped<ICreatePaymentIntentService, CreatePaymentIntentService>();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowSpecificOrigin");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();