/*
 * multi line comment
 * comment
 * comment
 */

/*
Console.WriteLine("Welcome to Bethany's Pie Shop HRM");

Console.WriteLine("Please enter your name: ");

string name = Console.ReadLine();
*/
//string name2 = Console.ReadLine();

var monthlyWage = 1234;//implicit typing when the program is compiled the compiler will know what type this is, an integer.

int months = 12, bonus = 1000;

var isActive = true;//implicit typing, based on the right hand side of the assignment operator (=). bool is inferred.

double rating = 99.25;

//byte numberOfEmployees = 300;
/*
int hoursWorked;

hoursWorked = 125;

hoursWorked = 148;

//monthlyWage = true;

const double interestRate = 0.07;

string firstName = "Bethany";
string lastName = "Smith";

string emptyString = "";

Console.WriteLine("Please enter your name");
string name = Console.ReadLine();
*/

/*
double ratePerHour = 12.34;
int numberOfHoursWorked = 165;

double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;    
Console.WriteLine(currentMonthWage);

ratePerHour += 3; // ratePerHour = ratePerHour + 3;
Console.WriteLine(ratePerHour);

if (currentMonthWage > 2000)
    Console.WriteLine("Top Paid Employee");

int numberOfEmployees = 15;
numberOfEmployees--;
*/
//bool a;
//int b;

//int intMaxValue = int.MaxValue;
//int intMinValue = int.MinValue;

//char userSelection = 'a';
//char upperVersion = char.ToUpper(userSelection);

//bool isDigit = char.IsDigit(userSelection);

//bool isLetter = char.IsLetter(userSelection);

//DateTime hireDate = new DateTime(2022, 3, 28, 14, 30, 0);
//Console.WriteLine(hireDate);

//DateTime exitDate = new DateTime(2025, 12, 11);

//DateTime startDate = hireDate.AddDays(15);

//DateTime currentDate = DateTime.Now;
//bool areWeInDst = currentDate.IsDaylightSavingTime();

//DateTime startHour = DateTime.Now;
//TimeSpan workTime = new TimeSpan(8, 35, 0);
//DateTime endHour = startHour.Add(workTime);

//Console.WriteLine(startHour.ToLongDateString());
//Console.WriteLine(endHour.ToShortTimeString());

int numberOfHoursWorked = 165;

long veryLongMonth = numberOfHoursWorked;

double d = 12345.0;

int x = (int) d;//potential data loss because we're forcing a double into an integer type.

int intVeryLongMonth = (int)veryLongMonth;//possible data los because a long may have two many numbers than an int can hold.



Console.ReadLine(); 