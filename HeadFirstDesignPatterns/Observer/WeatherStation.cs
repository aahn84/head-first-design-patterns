using System;
using System.Collections.Generic;
using System.Text;

namespace app.HeadFirstDesignPatterns.Observer
{
    public class WeatherStation
    {
        public static void Run()
        {
            var weatherData = new WeatherData();
            
            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            var statisticsDisplay = new StatisticsDisplay(weatherData);
            var forecastDisplay = new ForecastDisplay(weatherData);
            var heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            Console.WriteLine("-----");
            weatherData.SetMeasurements(82, 70, 29.2f);
            Console.WriteLine("-----");
            weatherData.SetMeasurements(78, 90, 29.2f);
            Console.WriteLine("-----");
        }

    }
}
