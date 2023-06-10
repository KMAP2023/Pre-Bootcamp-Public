var builder = WebApplication.CreateBuilder(args);
// Add our service
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Our builder code ==> must be placed after the var app = builder.Build();
app.UseStaticFiles(); // by incorporating this it is used to describe any of the CSS, images or JS you bring into a project
app.UseRouting();
app.UseAuthorization();
// where you place these is important

// start mapping to our controller
app.MapControllerRoute(    
    name: "default",    
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
