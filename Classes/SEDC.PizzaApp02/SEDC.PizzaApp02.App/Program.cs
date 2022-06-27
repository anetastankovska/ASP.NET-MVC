using AutoMapper;
using SEDC.PizzaApp02.App.Models.Domain;
using SEDC.PizzaApp02.App.Models.ViewModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();


var app = builder.Build();

// Configure AutoMapper
var config = new MapperConfiguration(cfg =>

cfg.CreateMap<Order, OrderDetailsViewModel>()
.ForMember(dest => dest.PizzaName, act => act.MapFrom(Order => Order.Pizza.Name))
.ForMember(dest => dest.UserFullName, act => act.MapFrom(Order => Order.User.FirstName))
.ForMember(dest => dest.PaymentMethod, act => act.MapFrom(Order => Order.PaymentMethod))
.ForMember(dest => dest.Price, act => act.MapFrom(Order => Order.Pizza.Price))
.ForMember(dest => dest.IsDelivered, act => act.MapFrom(Order => Order.IsDelivered))

);

var mapper = new Mapper(config);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
