using Animal;
using AnimalImplementation;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();



ServiceDescriptor serviceDescriptor = new ServiceDescriptor(typeof(AnimalsInterface), typeof(ImplementationOfAnimal), ServiceLifetime.Scoped);
builder.Services.Add(serviceDescriptor);
var app = builder.Build();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dependency}/{action=RazorDependencyInjection}/{id?}");

app.Run();
