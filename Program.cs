﻿// CS 1400 - Lab 7: Conversions

// Selection Menu Driver
string[] unitTemperatureOptions = new string[] {
	"Fahrenheit to Celsius",
	"Fahrenheit to Kelvin",
	"Celsius to Fahrenheit",
	"Celsius to Kelvin",
	"Kelvin to Fahrenheit",
	"Kelvin to Celsius",
};
string[] unitLengthOptions = new string[] {
	"Inches to Feet",
	"Inches to Yards",
	"Feet to Inches",
	"Feet to Yards",
	"Yards to Inches",
	"Yards to Feet",	
};
string[] unitTimeOptions = new string[] {
	"Seconds to Minutes",
	"Seconds to Hours",
	"Minutes to Seconds",
	"Minutes to Hours",
	"Hours to Seconds",
	"Hours to Minutes",	
};

bool menuBool = true;
int userSelection = 0;
double inputValue = 0.0;

while (menuBool) {

	Console.WriteLine("-- Unit Conversion Menu --");
	Console.WriteLine("Press [ESC] to exit.");

	int unitTypeAmount = Enum.GetNames(typeof(UnitOptions)).Length;
	for (int i = 0; i < unitTypeAmount; i++) {
		Console.WriteLine($"[{i+1}] - {(UnitOptions)i}");
	}

	Snippet.Break();
	Console.Write("Input selection number > ");
	userSelection = int.Parse(Console.ReadLine());

// Temperature Conversion
	if (userSelection == (int)UnitOptions.Temperature+1) {

		Console.WriteLine("-- Temperature Conversion Menu --");

		for (int i = 0; i < unitTemperatureOptions.Length; i++) {
			Console.WriteLine($"[{i+1}] - {unitTemperatureOptions[i]}");
		}

		Snippet.Break();
		Console.Write("Input selection number > ");
		userSelection = int.Parse(Console.ReadLine());

		Console.WriteLine(unitTemperatureOptions[userSelection-1]);
		Snippet.Break();
		
		Console.WriteLine("Input value to convert >");
		inputValue = Double.Parse(Console.ReadLine());
		Snippet.Note(inputValue);
	}


// Length Conversion
	else if (userSelection == (int)UnitOptions.Length+1) {

		Console.WriteLine("-- Length Conversion Menu --");

		for (int i = 0; i < unitLengthOptions.Length; i++) {
			Console.WriteLine($"[{i+1}] - {unitLengthOptions[i]}");
		}

		Snippet.Break();
		Console.Write("Input selection number > ");
		userSelection = int.Parse(Console.ReadLine());

		Console.WriteLine(unitLengthOptions[userSelection-1]);
		Snippet.Break();

		Console.WriteLine("Input value to convert >");
		inputValue = Double.Parse(Console.ReadLine());
		Snippet.Note(inputValue);
	}


// Time Conversion
	else if (userSelection == (int)UnitOptions.Time+1) {

		Console.WriteLine("-- Time Conversion Menu --");

		for (int i = 0; i < unitTimeOptions.Length; i++) {
			Console.WriteLine($"[{i+1}] - {unitTimeOptions[i]}");
		}

		Snippet.Break();
		Console.Write("Input selection number > ");
		userSelection = int.Parse(Console.ReadLine());

		Console.WriteLine(unitTimeOptions[userSelection-1]);
		Snippet.Break();

		Console.WriteLine("Input value to convert >");
		inputValue = Double.Parse(Console.ReadLine());
		Snippet.Note(inputValue);
	}


// Invalid Input
	else {

		Console.WriteLine($"\"{userSelection}\" is an invalid input.");
	}

// End Operation
	Console.WriteLine("Press any key to continue...");
	Console.ReadKey();
}

// ------------------------------------------------------------------
// Temperature Unit Conversion
Snippet.Note("39 - Temperature Unit Conversions");
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
length = (InchesToFeet(13.0), UnitLength.Feet, markerFeet);
Snippet.Note(length.Item2 + ": " + length.Item1 + length.Item3);
Snippet.Break();

double InchesToYards(double inches) {

	double yards = 0.0;
	yards = inches / 36.0;

	return yards;
}
length = (InchesToYards(13.0), UnitLength.Yards, markerYards);
Snippet.Note(length.Item2 + ": " + length.Item1 + length.Item3);
Snippet.Break();


double FeetToInches(double feet) {

	double inches = 0.0;
	inches = feet * 12.0;

	return inches;
}
length = (FeetToInches(13.0), UnitLength.Inches, markerInches);
Snippet.Note(length.Item2 + ": " + length.Item1 + length.Item3);
Snippet.Break();

double FeetToYards(double feet) {

	double yards = 0.0;
	yards = feet / 3.0;

	return yards;
}
length = (FeetToYards(13.0), UnitLength.Yards, markerYards);
Snippet.Note(length.Item2 + ": " + length.Item1 + length.Item3);
Snippet.Break();


double YardsToInches(double yards) {

	double inches = 0.0;
	inches = yards * 36;

	return inches;
}
length = (YardsToInches(13.0), UnitLength.Inches, markerInches);
Snippet.Note(length.Item2 + ": " + length.Item1 + length.Item3);
Snippet.Break();

double YardsToFeet(double yards) {

	double feet = 0.0;
	feet = yards * 3.0;

	return feet;
}
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
time = (SecondsToMinutes(55.0), UnitTime.Minutes, markerMinutes);
Snippet.Note(time.Item2 + ": " + time.Item1 + time.Item3);
Snippet.Break();

double SecondsToHours(double seconds) {

	double hours = 0.0;
	hours = seconds / 3_600.0;

	return hours;
}
time = (SecondsToHours(55.0), UnitTime.Hours, markerHours);
Snippet.Note(time.Item2 + ": " + time.Item1 + time.Item3);
Snippet.Break();


double MinutesToSeconds(double minutes) {

	double seconds = 0.0;
	seconds = minutes * 60.0;

	return seconds;
}
time = (MinutesToSeconds(55.0), UnitTime.Seconds, markerSeconds);
Snippet.Note(time.Item2 + ": " + time.Item1 + time.Item3);
Snippet.Break();

double MinutesToHours(double minutes) {

	double hours = 0.0;
	hours = minutes / 60.0;

	return hours;
}
time = (MinutesToHours(55.0), UnitTime.Hours, markerHours);
Snippet.Note(time.Item2 + ": " + time.Item1 + time.Item3);
Snippet.Break();

double HoursToSeconds(double hours) {

	double seconds = 0.0;
	seconds = hours * 3_600;

	return seconds;
}
time = (HoursToSeconds(55.0), UnitTime.Seconds, markerSeconds);
Snippet.Note(time.Item2 + ": " + time.Item1 + time.Item3);
Snippet.Break();

double HoursToMinutes(double hours) {

	double minutes = 0.0;
	minutes = hours * 60.0;

	return minutes;
}
time = (HoursToMinutes(55.0), UnitTime.Minutes, markerMinutes);
Snippet.Note(time.Item2 + ": " + time.Item1 + time.Item3);
Snippet.Break();


// ------------------------------------------------------------------

enum UnitOptions {

	Temperature,
	Length,
	Time,
}

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