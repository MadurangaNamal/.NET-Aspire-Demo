using WeatherApp.Api;

namespace WeatherApp.Web;

public class WeatherApiClient
{
    private readonly HttpClient _httpClient;
    public WeatherApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<WeatherForecast>> GetWeatherForecastAsync()
    {
        var response = await _httpClient.GetAsync("weatherforecast");
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IEnumerable<WeatherForecast>>()
               ?? Enumerable.Empty<WeatherForecast>();
    }
}
