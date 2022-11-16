using veterinaria.yara.application.ioc;
using veterinaria.yara.infrastructure.extentions;
using veterinaria.yara.infrastructure.ioc;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

//var host = builder.Build();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//builder.Services.RegisterDependencies();
builder.Services.AddInfraestructure(builder.Configuration);
builder.Services.AddApplication();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


//Configurando HTTP request

app.ConfigureMetricServer();
app.ConfigureExceptionHandler();

app.UseCors(x => x
.AllowAnyMethod()
.AllowAnyHeader()
.SetIsOriginAllowed(origin => true)
.AllowCredentials()
);

//app.UseAuthorization();
app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();
app.Run();
