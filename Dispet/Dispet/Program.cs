using Dispet.Components;
using Dispet.Services;
using Dispet.ViewModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Configuración de servicios adicionales para MongoDB, Product y User
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<MongoDbService>();           // Servicio para conectarse a MongoDB
builder.Services.AddTransient<ProductService>();           // Servicio de productos
builder.Services.AddTransient<UserService>();              // Servicio de usuarios
builder.Services.AddTransient<ProductViewModel>();         // ViewModel para productos
builder.Services.AddTransient<UserViewModel>();            // ViewModel para usuarios

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

// Mantener solo la estructura de componentes y páginas originales
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
