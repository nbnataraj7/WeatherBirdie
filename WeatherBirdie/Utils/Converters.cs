using System;

namespace WeatherBirdie
{
	public class Converters
	{
		public Converters ()
		{
		}

		/// <summary>
		/// Kelvins to celsius.
		/// </summary>
		/// <returns>Kelvin to celsius.</returns>
		/// <param name="kelvin">Kelvin</param>
		public float KelvinToCelsius(float kelvin){
			return (float) (kelvin - 273.15);
		}

		/// <summary>
		/// Celsiuses to kelvin.
		/// </summary>
		/// <returns>Celsius to kelvin.</returns>
		/// <param name="celsius">Celsius</param>
		public float CelsiusToKelvin(float celsius){
			return (float) (celsius + 273.15);
		}

	}
}

