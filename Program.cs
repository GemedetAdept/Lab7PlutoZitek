// CS 1400 - Lab 7: Conversions

// Temperature Unit Conversion

string markerCelsius = " °C";
string markerFahrenheit = " °F";
string markerKelvin = " K";
(double, UnitTemperature, string) temperature = (0.0, UnitTemperature.Celsius, markerCelsius);


static double FahrenheitToCelsius(double fahrenheit) {
	double celsius = 0.0;
	celsius = (fahrenheit - 32.0) * (5/9);

	return celsius;
};

Snippet.Note("function: FahrenheitToCelsius -- 18");
Snippet.Note("Input: 32.0; Expected Output: 0.0;");
Snippet.Note("Output:");
temperature = (FahrenheitToCelsius(32.0), UnitTemperature.Celsius, markerCelsius);
Snippet.Note(temperature);
Snippet.Note(temperature.Item2 + ": " + temperature.Item1 + temperature.Item3);
Snippet.Break();


static double FahrenheitToKelvin(double fahrenheit) {
	double kelvin = 0.0;
	kelvin = (fahrenheit + 459.67) * 5/9;

	return kelvin;
};

Snippet.Note("function: FahrenheitToKelvin -- 34");
Snippet.Note("Input: 32.0; Expected Output: 273.15;");
Snippet.Note("Output:");
temperature = (FahrenheitToKelvin(32.0), UnitTemperature.Kelvin, markerKelvin);
Snippet.Note(temperature);
Snippet.Note(temperature.Item2 + ": " + temperature.Item1 + temperature.Item3);
Snippet.Break();


static double CelsiusToFahrenheit(double celsius) {
	double fahrenheit = 0.0;
	fahrenheit = celsius * 9/5 + 32;

	return fahrenheit;
};

Snippet.Note("function: CelsiusToFahrenheit -- 43");
Snippet.Note("Input: 32.0; Expected Output: 89.6;");
Snippet.Note("Output:");
temperature = (CelsiusToFahrenheit(32.0), UnitTemperature.Fahrenheit, markerFahrenheit);
Snippet.Note(temperature);
Snippet.Note(temperature.Item2 + ": " + temperature.Item1 + temperature.Item3);
Snippet.Break();


static double CelsiusToKelvin(double celsius) {

	double kelvin = 0.0;
	kelvin = celsius + 273.15;

	return kelvin;
};

Snippet.Note("function: CelsiusToKelvin -- 46");
Snippet.Note("Input: 32.0; Expected Output: 305.15;");
Snippet.Note("Output:");
Snippet.Note(CelsiusToKelvin(32.0));
Snippet.Break();


// static double KelvinToFahrenheit(double kelvin) {

// 	double fahrenheit = 0.0;
// 	fahrenheit = kelvin * 9/5 - 459.67;

// 	return fahrenheit;
// };

// Snippet.Note("function: KelvinToFahrenheit -- 58");
// Snippet.Note("Input: 32.0; Expected Output: -402.07;");
// Snippet.Note("Output:");
// Snippet.Note(KelvinToFahrenheit(32.0));
// Snippet.Break();


// static double KelvinToCelsius(double kelvin) {

// 	double celsius = 0.0;
// 	celsius = kelvin - 273.15;

// 	return celsius;
// };

// Snippet.Note("function: KelvinToCelsius -- 70");
// Snippet.Note("Input: 32.0; Expected Output: -241.15;");
// Snippet.Note("Output:");
// Snippet.Note(KelvinToCelsius(32.0));
// Snippet.Break();

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