var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.WeatherApp_Api>("weatherapp-api");

builder.AddProject<Projects.WeatherApp_Web>("weatherapp-web")
    .WithReference(api);

builder.Build().Run();
