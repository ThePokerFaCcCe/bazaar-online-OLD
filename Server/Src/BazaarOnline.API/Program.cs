using System.Text;
using BazaarOnline.Application.FluentValidations;
using BazaarOnline.Infra.Data.Contexts;
using BazaarOnline.Infra.Data.Seeds;
using BazaarOnline.Infra.IoC;
using FluentValidation.AspNetCore;
using MicroElements.Swashbuckle.FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// DotNetEnv
DotNetEnv.Env.Load();

// CORS
string NextJsOrigin = "NextJS";
builder.Services.AddCors(options =>
{
    options.AddPolicy(NextJsOrigin, builder =>
    {
        builder.WithOrigins("localhost:3000").AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});


builder.Services.AddControllers()
    .AddXmlSerializerFormatters();

// DB
builder.Services.AddDbContext<BazaarDbContext>(options =>
    options.UseSqlServer(DotNetEnv.Env.GetString("CONNECTION_STRING")));

// Authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})

// Adding Jwt Bearer
.AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = false,
        ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(System.Environment.GetEnvironmentVariable("JWT__SIGNKEY"))),
        TokenDecryptionKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(System.Environment.GetEnvironmentVariable("JWT__ENCRYPTKEY")))
    };
});



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("V1", new OpenApiInfo
    {
        Version = "V1",
        Title = "Bazaar API",
        Description = "Main API Documentation of Bazaar API",
        License = new OpenApiLicense { Name = "MIT" },
        Contact = new OpenApiContact
        {
            Email = "matin.khaleghi.nezhad@gmail.com",
            Name = "Matin Khaleghi"
        }
    });
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please insert JWT with Bearer into field",
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement {
    {
        new OpenApiSecurityScheme
        {
        Reference = new OpenApiReference
        {
            Type = ReferenceType.SecurityScheme,
            Id = "Bearer"
        }
        },
        new string[] { }
    }
    });
    options.SchemaFilter<DescribeEnumMembers>();
});
// Fluent Validation
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidation(config =>
{
    config.RegisterValidatorsFromAssembly(typeof(UserCreateFluentValidation).Assembly);
});
builder.Services.AddFluentValidationRulesToSwagger();

DependencyContainer.RegisterService(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/V1/swagger.json", "V1");
    });
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        ExampleSeeder.Seed(services, forceRecreate: true);
    }
}

app.UseCors(NextJsOrigin);

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
