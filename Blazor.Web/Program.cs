var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<Billing_POCBlazorContext>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("SampleDBContext")));
builder.Services.AddDbContext<StoredProcedureClass>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("SampleDBContext")));
builder.Services.AddScoped<ISampleService, SampleService>();
builder.Services.AddScoped<IBaseStoredProc, BaseStoredProc>();
builder.Services.AddScoped(typeof(IBlazorRepository<>), typeof(BlazorRepository<>));
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddSyncfusionBlazor();

var app = builder.Build();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzQwOTU2QDMyMzAyZTMzMmUzMGVGc1hFM05BZ1pOdHphalRCb1k4QXRobUVnZExETWdWbkZuQ1ozYlFVRFk9");
Bold.Licensing.BoldLicenseProvider.RegisterLicense("lKMMgxZmDZijHmEYXM7eVicpgjDA1m6t+NhVYKvAFWs=");
// Configure the HTTP request pipeline middleware.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

await app.RunAsync();
