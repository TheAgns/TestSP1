using App;

namespace Test;

public class TemperatureConverterTest {
        [Fact]
        public void TestFahrenheitToCelsius()
        {
            var converter = new FahrenheitConverter();
            var result = converter.FahrenheitToCelsius(32);
            Assert.Equal(0, result);
        
            result = converter.FahrenheitToCelsius(212);
            Assert.Equal(100, result);
        }
        
}