// CS 1400 - Lab 7: Conversions

// Temperature Unit Conversion
string markerCelsius = " °C";
string markerFahrenheit = " °F";
string markerKelvin = " K";
(double, UnitTemperature, string) temperature = (0.0, UnitTemperature.Celsius, markerCelsius);

// Fahrenheit to Celsius and Kelvin
double FahrenheitToCelsius(double fahrenheit) {
	double celsius = 0.0;
	celsius = (fahrenheit - 32.0) * (5/9);

	return celsius;
};
temperature = (FahrenheitToCelsius(32.0), UnitTemperature.Celsius, markerCelsius);
Snippet.Note(temperature.Item2 + ": " + temperature.Item1 + temperature.Item3);
Snippet.Break();

double FahrenheitToKelvin(double fahrenheit) {
	double kelvin = 0.0;
	kelvin = (fahrenheit + 459.67) * 5/9;

	return kelvin;
};
temperature = (FahrenheitToKelvin(32.0), UnitTemperature.Kelvin, markerKelvin);
Snippet.Note(temperature.Item2 + ": " + temperature.Item1 + temperature.Item3);
Snippet.Break();


// Celsius to Fahrenheit and Kelvin
double CelsiusToFahrenheit(double celsius) {
	double fahrenheit = 0.0;
	fahrenheit = celsius * 9/5 + 32;

	return fahrenheit;
};
temperature = (CelsiusToFahrenheit(32.0), UnitTemperature.Fahrenheit, markerFahrenheit);
Snippet.Note(temperature.Item2 + ": " + temperature.Item1 + temperature.Item3);
Snippet.Break();

double CelsiusToKelvin(double celsius) {

	double kelvin = 0.0;
	kelvin = celsius + 273.15;

	return kelvin;
};
temperature = (CelsiusToKelvin(32.0), UnitTemperature.Kelvin, markerKelvin);
Snippet.Note(temperature.Item2 + ": " + temperature.Item1 + temperature.Item3);
Snippet.Break();


// Kelvin to Fahrenheit and Celsius
double KelvinToFahrenheit(double kelvin) {

	double fahrenheit = 0.0;
	fahrenheit = kelvin * 9/5 - 459.67;

	return fahrenheit;
};
temperature = (KelvinToFahrenheit(32.0), UnitTemperature.Fahrenheit, markerFahrenheit);
Snippet.Note(temperature.Item2 + ": " + temperature.Item1 + temperature.Item3);
Snippet.Break();

double KelvinToCelsius(double kelvin) {

	double celsius = 0.0;
	celsius = kelvin - 273.15;

	return celsius;
};
temperature = (KelvinToCelsius(32.0), UnitTemperature.Celsius, markerCelsius);
Snippet.Note(temperature.Item2 + ": " + temperature.Item1 + temperature.Item3);
Snippet.Break();

// ------------------------------------------------------------------
// Length Unit Conversion
Snippet.Note("79 - Length Unit Conversions");
string markerInches = " inch(es)";
string markerFeet = " feet";
string markerYards = " yard(s)";
(double, UnitLength, string) length = (0.0, UnitLength.Inches, markerInches);

double InchesToFeet(double inches) {
	
	double feet = 0.0;
	feet = inches / 12.0;

	return feet;	
};
Snippet.Note("92 - InchesToFeet; Input: 13.0; Expected Output: 1.08333;");
length = (InchesToFeet(13.0), UnitLength.Feet, markerFeet);
Snippet.Note(length.Item2 + ": " + length.Item1 + length.Item3);
Snippet.Break();

double InchesToYards(double inches) {

	double yards = 0.0;
	yards = inches / 36.0;

	return yards;
}
Snippet.Note("97 - InchesToYards; Input: 13.0; Expected Output: 0.36111;");
length = (InchesToYards(13.0), UnitLength.Yards, markerYards);
Snippet.Note(length.Item2 + ": " + length.Item1 + length.Item3);
Snippet.Break();


double FeetToInches(double feet) {

	double inches = 0.0;
	inches = feet * 12.0;

	return inches;
}
Snippet.Note("110 - FeetToInches; Input: 13.0; Expected Output: 156;");
length = (FeetToInches(13.0), UnitLength.Inches, markerInches);
Snippet.Note(length.Item2 + ": " + length.Item1 + length.Item3);
Snippet.Break();

double FeetToYards(double feet) {

	double yards = 0.0;
	yards = feet / 3.0;

	return yards;
}
Snippet.Note("122 - FeetToYards; Input: 13.0; Expected Output: 4.33333;");
length = (FeetToYards(13.0), UnitLength.Yards, markerYards);
Snippet.Note(length.Item2 + ": " + length.Item1 + length.Item3);
Snippet.Break();


double YardsToInches(double yards) {

	double inches = 0.0;
	inches = yards * 36;

	return inches;
}
Snippet.Note("135 - YardsToInches; Input: 13.0; Expected Output: 468;");
length = (YardsToInches(13.0), UnitLength.Inches, markerInches);
Snippet.Note(length.Item2 + ": " + length.Item1 + length.Item3);
Snippet.Break();

double YardsToFeet(double yards) {

	double feet = 0.0;
	feet = yards * 3.0;

	return feet;
}
Snippet.Note("147 - YardsToFeet; Input: 13.0; Expected Output: 39");
length = (YardsToFeet(13.0), UnitLength.Feet, markerFeet);
Snippet.Note(length.Item2 + ": " + length.Item1 + length.Item3);
Snippet.Break();

// ------------------------------------------------------------------
// Time Unit Conversion
Snippet.Note("161 - Time Unit Conversions");
string markerSeconds = " second(s)";
string markerMinutes = " minute(s)";
string markerHours = " hour(s)";
(double, UnitTime, string) time = (0.0, UnitTime.Seconds, markerSeconds);

double SecondsToMinutes(double seconds) {

	double minutes = 0.0;
	minutes = seconds / 60.0;

	return minutes;
}
Snippet.Note("167 - SecondsToMinutes; Input 55.0; Expected Output: 0.91666");
time = (SecondsToMinutes(55.0), UnitTime.Minutes, markerMinutes);
Snippet.Note(time.Item2 + ": " + time.Item1 + time.Item3);
Snippet.Break();

double SecondsToHours(double seconds) {

	double hours = 0.0;
	hours = seconds / 3_600.0;

	return hours;
}
Snippet.Note("179 - SecondsToHours; Input 55.0; Expected Output: 0.01527");
time = (SecondsToHours(55.0), UnitTime.Hours, markerHours);
Snippet.Note(time.Item2 + ": " + time.Item1 + time.Item3);
Snippet.Break();

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