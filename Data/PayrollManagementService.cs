namespace BlazorApp.Data;

public class WeatherForecastService
{
    private static readonly string[] Months = new[]
    {
        "September 2021", "October 2021", "November 2021", "December 2021", "January 2022"
    };

    public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
    {
        return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = startDate.AddDays(index),
            Month = Months[Random.Shared.Next(Months.Length)],
            /*Pay = Payroll[Random.Shared.Next(-20, 55)*/
        }).ToArray());
    }
}
