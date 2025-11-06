// parse
using System.Globalization;

string numberString = "123";
int number = int.Parse(numberString);
Console.WriteLine(number);

string dateString = "05.11.2025";
DateTime date1 = DateTime.Parse(dateString);
Console.WriteLine(date1);

// parseExact(
string dateExactString = "2007-07-09";
string format = "yyyy-MM-dd";
DateTime date2 = DateTime.ParseExact(dateExactString, format, CultureInfo.InvariantCulture);
Console.WriteLine(date2);

// tryParse
string error = "12a3";

if (int.TryParse(error, out int result))
    Console.WriteLine(result);
else
{
    Console.WriteLine(false);
}

string correct = "456";

if (int.TryParse(correct, out int result2))
    Console.WriteLine(result2);

// tryParseExact()
string dateTryStr = "11/04/2025";
string expectedFormat = "MM/dd/yyyy";
if (DateTime.TryParseExact(dateTryStr, expectedFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateResult))
{
    Console.WriteLine(dateResult);
}
else
{
    Console.WriteLine(false);
}