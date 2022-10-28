// CS 1400 - Lab 7: Conversions

void invalidInput(int invalidValue) {
	Console.WriteLine($"\"{invalidValue}\" is an invalid input.");
};

string markerCelsius = " °C";
string markerFahrenheit = " °F";
string markerKelvin = " K";
(double, UnitTemperature, string) temperature = (0.0, UnitTemperature.Celsius, markerCelsius);

string markerInches = " inch(es)";
string markerFeet = " feet";
string markerYards = " yard(s)";
(double, UnitLength, string) length = (0.0, UnitLength.Inches, markerInches);

string markerSeconds = " second(s)";
string markerMinutes = " minute(s)";
string markerHours = " hour(s)";
(double, UnitTime, string) time = (0.0, UnitTime.Seconds, markerSeconds);

// ------------------------------------------------------------------

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
	Console.WriteLine("Type \"0\" to exit.");

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

		Console.Clear();
		Console.WriteLine(unitTemperatureOptions[userSelection-1]);
		Snippet.Break();

		Console.Write("Input value to convert > ");
		inputValue = Double.Parse(Console.ReadLine());

		switch (userSelection){

			case 1:
				FahrenheitToCelsius(inputValue);
				temperature = (FahrenheitToCelsius(32.0), UnitTemperature.Celsius, markerCelsius);
				Console.WriteLine(temperature.Item2 + ": " + temperature.Item1 + temperature.Item3);
				break;
			case 2:
				Console.WriteLine(FahrenheitToKelvin(inputValue));
				break;
			case 3:
				Console.WriteLine(CelsiusToFahrenheit(inputValue));
				break;
			case 4:
				Console.WriteLine(CelsiusToKelvin(inputValue));
				break;	
			case 5:
				Console.WriteLine(KelvinToFahrenheit(inputValue));
				break;
			case 6:
				Console.WriteLine(KelvinToCelsius(inputValue));
				break;
			default:
				invalidInput(userSelection);
				break;
		}
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

		Console.Clear();
		Console.WriteLine(unitLengthOptions[userSelection-1]);
		Snippet.Break();

		Console.WriteLine("Input value to convert > ");
		inputValue = Double.Parse(Console.ReadLine());

		switch (userSelection){

			case 1:
				Console.WriteLine(InchesToFeet(inputValue));
				break;
			case 2:
				Console.WriteLine(InchesToYards(inputValue));
				break;
			case 3:
				Console.WriteLine(FeetToInches(inputValue));
				break;
			case 4:
				Console.WriteLine(FeetToYards(inputValue));
				break;	
			case 5:
				Console.WriteLine(YardsToInches(inputValue));
				break;
			case 6:
				Console.WriteLine(YardsToFeet(inputValue));
				break;
			default:
				invalidInput(userSelection);
				break;
		}
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

		Console.Clear();
		Console.WriteLine(unitTimeOptions[userSelection-1]);
		Snippet.Break();

		Console.WriteLine("Input value to convert > ");
		inputValue = Double.Parse(Console.ReadLine());

		switch (userSelection){

			case 1:
				Console.WriteLine(SecondsToMinutes(inputValue));
				break;
			case 2:
				Console.WriteLine(SecondsToHours(inputValue));
				break;
			case 3:
				Console.WriteLine(MinutesToSeconds(inputValue));
				break;
			case 4:
				Console.WriteLine(MinutesToHours(inputValue));
				break;	
			case 5:
				Console.WriteLine(HoursToSeconds(inputValue));
				break;
			case 6:
				Console.WriteLine(HoursToMinutes(inputValue));
				break;
			default:
				invalidInput(userSelection);
				break;
		}
	}

	else if (userSelection == 0) {

		Console.Clear();
		Environment.Exit(0);
	}

// Invalid Input
	else {

		invalidInput(userSelection);
	}

// End Operation
	Console.WriteLine("Press any key to continue...");
	Console.ReadKey();
}

// ------------------------------------------------------------------
// Temperature Unit Conversion

// Fahrenheit to Celsius and Kelvin
double FahrenheitToCelsius(double fahrenheit) {
	double celsius = 0.0;
	celsius = (fahrenheit - 32.0) * 5/9;

	return celsius;
};

double FahrenheitToKelvin(double fahrenheit) {
	double kelvin = 0.0;
	kelvin = (fahrenheit + 459.67) * 5/9;

	return kelvin;
};


// Celsius to Fahrenheit and Kelvin
double CelsiusToFahrenheit(double celsius) {
	double fahrenheit = 0.0;
	fahrenheit = celsius * 9/5 + 32;

	return fahrenheit;
};

double CelsiusToKelvin(double celsius) {

	double kelvin = 0.0;
	kelvin = celsius + 273.15;

	return kelvin;
};


// Kelvin to Fahrenheit and Celsius
double KelvinToFahrenheit(double kelvin) {

	double fahrenheit = 0.0;
	fahrenheit = kelvin * 9/5 - 459.67;

	return fahrenheit;
};

double KelvinToCelsius(double kelvin) {

	double celsius = 0.0;
	celsius = kelvin - 273.15;

	return celsius;
};

// ------------------------------------------------------------------
// Length Unit Conversion

double InchesToFeet(double inches) {
	
	double feet = 0.0;
	feet = inches / 12.0;

	return feet;	
};

double InchesToYards(double inches) {

	double yards = 0.0;
	yards = inches / 36.0;

	return yards;
}


double FeetToInches(double feet) {

	double inches = 0.0;
	inches = feet * 12.0;

	return inches;
}

double FeetToYards(double feet) {

	double yards = 0.0;
	yards = feet / 3.0;

	return yards;
}


double YardsToInches(double yards) {

	double inches = 0.0;
	inches = yards * 36;

	return inches;
}

double YardsToFeet(double yards) {

	double feet = 0.0;
	feet = yards * 3.0;

	return feet;
}

// ------------------------------------------------------------------
// Time Unit Conversion

double SecondsToMinutes(double seconds) {

	double minutes = 0.0;
	minutes = seconds / 60.0;

	return minutes;
}

double SecondsToHours(double seconds) {

	double hours = 0.0;
	hours = seconds / 3_600.0;

	return hours;
}


double MinutesToSeconds(double minutes) {

	double seconds = 0.0;
	seconds = minutes * 60.0;

	return seconds;
}

double MinutesToHours(double minutes) {

	double hours = 0.0;
	hours = minutes / 60.0;

	return hours;
}


double HoursToSeconds(double hours) {

	double seconds = 0.0;
	seconds = hours * 3_600;

	return seconds;
}

double HoursToMinutes(double hours) {

	double minutes = 0.0;
	minutes = hours * 60.0;

	return minutes;
}

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