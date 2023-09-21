namespace Test;

public class TemperatureConverterTest {
    
        public void TestFahrenheitToCelsius()
        {
            var converter = new FahrenheitConverter();
            var result = converter.FahrenheitToCelsius(32);
            Assert.Equal(0, result);
        
            result = converter.FahrenheitToCelsius(212);
            Assert.Equal(100, result);
        }
        
        public void TestCelsiusToFahrenheit()
        {
            var converter = new Converter();
            var result = converter.CelsiusToFahrenheit(-17);
            Assert.Equal(1.4,result);
        }
    }
    
}