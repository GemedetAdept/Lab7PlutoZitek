// CS 1400 - Lab 7: Conversions

// Temperature Unit Conversion
string markerCelsius = " °C";
string markerFahrenheit = " °F";
string markerKelvin = " K";
(double, UnitTemperature, string) temperature = (0.0, UnitTemperature.Celsius, markerCelsius);

// Fahrenheit to Celsius and Kelvin
static double FahrenheitToCelsius(double fahrenheit) {
	double celsius = 0.0;
	celsius = (fahrenheit - 32.0) * (5/9);

	return celsius;
};
temperature = (FahrenheitToCelsius(32.0), UnitTemperature.Celsius, markerCelsius);
Snippet.Note(temperature.Item2 + ": " + temperature.Item1 + temperature.Item3);
Snippet.Break();

static double FahrenheitToKelvin(double fahrenheit) {
	double kelvin = 0.0;
	kelvin = (fahrenheit + 459.67) * 5/9;

	return kelvin;
};
temperature = (FahrenheitToKelvin(32.0), UnitTemperature.Kelvin, markerKelvin);
Snippet.Note(temperature.Item2 + ": " + temperature.Item1 + temperature.Item3);
Snippet.Break();


// Celsius to Fahrenheit and Kelvin
static double CelsiusToFahrenheit(double celsius) {
	double fahrenheit = 0.0;
	fahrenheit = celsius * 9/5 + 32;

	return fahrenheit;
};
temperature = (CelsiusToFahrenheit(32.0), UnitTemperature.Fahrenheit, markerFahrenheit);
Snippet.Note(temperature.Item2 + ": " + temperature.Item1 + temperature.Item3);
Snippet.Break();

static double CelsiusToKelvin(double celsius) {

	double kelvin = 0.0;
	kelvin = celsius + 273.15;

	return kelvin;
};
temperature = (CelsiusToKelvin(32.0), UnitTemperature.Kelvin, markerKelvin);
Snippet.Note(temperature.Item2 + ": " + temperature.Item1 + temperature.Item3);
Snippet.Break();


// Kelvin to Fahrenheit and Celsius
static double KelvinToFahrenheit(double kelvin) {

	double fahrenheit = 0.0;
	fahrenheit = kelvin * 9/5 - 459.67;

	return fahrenheit;
};
temperature = (KelvinToFahrenheit(32.0), UnitTemperature.Fahrenheit, markerFahrenheit);
Snippet.Note(temperature.Item2 + ": " + temperature.Item1 + temperature.Item3);
Snippet.Break();

static double KelvinToCelsius(double kelvin) {

	double celsius = 0.0;
	celsius = kelvin - 273.15;

	return celsius;
};
temperature = (KelvinToCelsius(32.0), UnitTemperature.Celsius, markerCelsius);
Snippet.Note(temperature.Item2 + ": " + temperature.Item1 + temperature.Item3);
Snippet.Break();

// ------------------------------------------------------------------
// Length Unit Conversion


// ------------------------------------------------------------------

enum UnitTemperature {

	Celsius,
	Fahrenheit,
	Kelvin,
}

enum UnitLength {

	Inches,
	Feet,
	Yards,
}

enum UnitTime {

	Seconds,
	Minutes,
	Hours,
}