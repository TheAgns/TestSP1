namespace App;

public class FahrenheitConverter {
    public double FahrenheitToCelsius(double fahrenheit) {
        //Fahrenheit til Celsius formel: (°F - 32) / 1.8 = °C
        return Math.Round((fahrenheit - 32) / 1.8, 1);
    }
    public double CelsiusToFahrenheit(double celsius) {
        //Celsius til Fahrenheit formel: (°C * 1.8) + 32 = °F
        return Math.Round((celsius * 1.8) + 32, 1);
    }
}