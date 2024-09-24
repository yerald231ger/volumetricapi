using VolumetricApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.MapGet("/jsonsByDate", async (string startDate, string endDate, string reportType, int stationId) =>
{
    switch (reportType)
    {
        case "Diario":
            return Results.Ok(new[]
            {
                VolumetricoDiarioModel.Create()
            });
        case "Mensual":
            return Results.Ok(new[]
            {
                VolumetricoMensualModel.Create()
            });
        default:
            return Results.BadRequest();
    }
});
app.Run();
