using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorwebAssembly;
using Supabase;
using Blazored.LocalStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


var supabaseUrl = builder.Configuration["Supabase:Url"];
var supabaseKey = builder.Configuration["Supabase:AnonKey"];

builder.Services.AddBlazoredLocalStorage();

// ✅ Create Supabase client
var supabaseClient = new Client(supabaseUrl, supabaseKey);
await supabaseClient.InitializeAsync();

// ✅ REGISTER Supabase client in DI
builder.Services.AddScoped<Client>(_ => supabaseClient);

// ✅ Backend API HttpClient
builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri("http://localhost:5099/")
    });

await builder.Build().RunAsync();
