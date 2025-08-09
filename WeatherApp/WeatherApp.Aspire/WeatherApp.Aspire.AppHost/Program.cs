var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("redisCache");
var api = builder.AddProject<Projects.WeatherApp_Api>("weatherapp-api");

builder.AddProject<Projects.WeatherApp_Web>("weatherapp-web")
    .WithReference(api)
    .WithReference(cache);

builder.Build().Run();
