using LaCaguamaBackend.Application.Service;
using LaCaguamaBackend.Domain.Interface;
using LaCaguamaBackend.Infraestructure;
using LaCaguamaBackend.Infraestructure.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<LaCaguamaDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        opt => opt.MigrationsAssembly(typeof(LaCaguamaDbContext).Assembly.FullName));
});

builder.Services.AddTransient<IInventarioRepository, InventarioRepository>();
builder.Services.AddTransient<IInventarioService, InventarioService>();
builder.Services.AddTransient<IProveedorRepository, ProveedorRepository>();
builder.Services.AddTransient<IProveedorService, ProveedorService>();
builder.Services.AddTransient<IBebidaRepository, BebidaRepository>();
builder.Services.AddTransient<IBebidaService, BebidaService>();
builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddTransient<ICategoriaService, CategoriaService>();
builder.Services.AddTransient<IFacturaRepository, FacturaRepository>();
builder.Services.AddTransient<IFacturaService, FacturaService>();
builder.Services.AddTransient<IExtraRepository, ExtraRepository>();
builder.Services.AddTransient<IExtraService, ExtraService>();
builder.Services.AddTransient<IPlatoRepository, PlatoRepository>();
builder.Services.AddTransient<IPlatoService,PlatoService>();
builder.Services.AddTransient<IMesaRepository, MesaRepository>();
builder.Services.AddTransient<IMesaService, MesaService>();
builder.Services.AddTransient<IMenuRepository, MenuRepository>();
builder.Services.AddTransient<IMenuService, MenuService>();



builder.Configuration.AddJsonFile("appsettings.json");
var secretKey = builder.Configuration.GetSection("settings")["secretKey"];
var keyBytes = Encoding.UTF8.GetBytes(secretKey);

builder.Services.AddAuthentication(config => {
    config.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    config.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(config => {
    config.RequireHttpsMetadata = false;
    config.SaveToken = true;
    config.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(keyBytes),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCorsPolicy", policy =>
    {
        policy.WithOrigins("https://localhost:7271")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("MyCorsPolicy");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
