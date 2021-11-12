using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightStats
{
    public class Measure
    {
        private double _temperatureInFahrenheit;
        private double _temperatureInCelsius;
        private double _temperatureInKelvin;
        private double _localSpeedOfSound;

        public Measure(double temperatureInFahrenheit)
        {
            _temperatureInFahrenheit = temperatureInFahrenheit;
        }

        public Measure(double temperatureInFahrenheit, double temperatureInCelsius)
        {
            _temperatureInFahrenheit = temperatureInFahrenheit;
            _temperatureInCelsius = temperatureInCelsius;
        }

        public Measure(double temperatureInFahrenheit, double temperatureInCelsius, double temperatureInKelvin)
        {
            _temperatureInFahrenheit = temperatureInFahrenheit;
            _temperatureInCelsius = temperatureInCelsius;
            _temperatureInKelvin = temperatureInKelvin;
        }

        public Measure(double temperatureInFahrenheit, double temperatureInCelsius, double temperatureInKelvin, double localSpeedOfSound)
        {
            _temperatureInFahrenheit = temperatureInFahrenheit;
            _temperatureInCelsius = temperatureInCelsius;
            _temperatureInKelvin = temperatureInKelvin;
            _localSpeedOfSound = localSpeedOfSound;
        }
        public override string ToString()
        {

            AeroConverter aeroConverter = new AeroConverter();
            _temperatureInCelsius ??= aeroConverter.ConvertFahrenheitToCelsius(_temperatureInFahrenheit);
            _temperatureInKelvin =  aeroConverter.ConvertFahrenheitToKelvin(_temperatureInFahrenheit);
            _localSpeedOfSound =  aeroConverter.LocalSpeedOfSound(_temperatureInKelvin);
            return $"{_temperatureInFahrenheit.ToString("0.00")};{_temperatureInCelsius.ToString("0.00")};{_temperatureInKelvin.ToString("0.00")};{_localSpeedOfSound.ToString("0.00")}";
        }
    }
}
