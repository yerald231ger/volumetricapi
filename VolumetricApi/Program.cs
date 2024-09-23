using VolumetricApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();
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

app.MapGet("/jsonDataByName", async (string jsonName, HttpClient client) =>
{ 
    if(string.IsNullOrEmpty(jsonName))
        return Results.BadRequest();
    
    try
    {
        client.BaseAddress = new Uri("https://splitterdevstoreacc.blob.core.windows.net");
        var result = await client.GetAsync($"/json-download/{jsonName}");
        
        if (!result.IsSuccessStatusCode) return Results.StatusCode(500);
        
        var stream = await result.Content.ReadAsStreamAsync();
        return Results.File(stream, "application/octet-stream", "FileJson");
    }
    catch (Exception ex)
    {
        return Results.NotFound(ex.Message);
    }

}).WithName("GetJsonData");

app.Run();