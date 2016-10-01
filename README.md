# epicU
note for class_ cheatsheet........

Data Type(CS-ASP_007)

comments // single line...   /* multiline comments*/

string => alphanumeric(defaults to "")

int=> 2 billion to -2 billion (defaults to 0)

double=>fractional value (default to 0.0)

bool=>true or false (defaults to false)

more: http://is.gd/data_types

Data type Conversion (CS-ASP_008)
======================================================
Implicit Conversions - smaller type to larger type
without data loss, "upcasting"

Explicit conversions - require developer intervention,
possibility of data loss, "downcasting", either in
the form of cast or using a helper method.

Casting numbers:
int myInteger =(int)myDouble;

Numbers to string:
string myString = myInteger.ToString();

String to Numbers;
int myInteger = int.Parse(myString);

More: http://is.gd/datatype_conversion


Arithmetic  Operators (CS-ASP-009)
=======================================================================
= Not equality, its assignment

Math Operators: +-*/

Addition Assignment
total = Total +5
total += 5;

Increment Operator: 1++:
Decrement Operator: 1--;

Beware of order of precedence (use parenthesis)
Beware of down casting (you'll lose precision)
Beware of overflow(user bigger types)

to make overflow throw an exeption:

{
//some arithmetic operation
//that could potentially overflow
}

c# Syntex (CS-ASP_010)
===============================================================================

Operands- variable names, object/server control names, literals - "nouns" (you name these)

Operators -"verbs...they act on the operands.

htpp://is.gd/operators

Expressions One or more operands and zero or more operators
that evaluate to a single value

http://is.gd/expressions

statements - A complete instruction - assigment of an 
expression to a variable, an increment/decremen, etc.

http://is.gd/statement

Statements must end in a semi-colon;
whitespace is ignored (use for humans)







/////////
This is a link for my website
http://432-bethuel.vm.epicservers.com/betwebsite/
type inet in the start____> to bring up internet information service manager.

c# Syntex evaluate (CS-ASP_011)
===============================================================================
= assignment
== equality

if(a == b){
//execute when the expression is true
}else{
//execute when the expression is false
}


... or ... evalutate other mutaully exclusively options:
if(a==b){//some code}
else if (a==c){//some code gos here}


Conditional Ternary operatoor(sc-asp_012)
==========================================================

result = (a == b)? "equal":"not equal";



Operators(sc-asp_013)
==========================================================
comparision operators
used for conditional statements
==
!=
<>
<=  >=
!somBoolean Value - means not is true

logical operators
used to combine multiple expressions/ evaluation

&& and
|| or

comvine with parenthesis () for order of precendence.

working with date s(sc-asp_014)
==========================================================
creating new DateTime objects
DateTime myDateTime = DateTime.Now;
DateTime myDateTime = DateTime("11/10/1979");

formatting ... many options:
myDateTime.to_____()

Retrieving Parts:
myDateTime.Year  //int
myDateTime.Hours //int
myDateTime.DayOfWeek //"Monday"
myDateTime.DayOfWeek //"Monday"
myDatetime.DayOfYear // int 173


DateTime Math;
MyDateTime.AddHour(3)
myDateTime.Addminute(-5)

"Chanining" = using multiple helper methods
together with the dot . operater
myDateTime.AddHour(3).AddMinute(-5).ToString();

working with spans of Time s(sc-asp_014)
==========================================================
create and initialize new TimeSpans

//Days.Hours:Minutes:Seconds.Milliseconds
TimeSpan myTimeSpan = TimeSpan.Parse("1.2:3:30.5");

DateTime myBirthday = DateTime.Parse("11/10/79");
TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

More info at http://is.gd/timespan

... or get TOTAL elapsed time
as a double representing both
the number of days / hours/ etc.
AND fractioal values representing 
"left overs",

MyTimeSpan.TotalDays //double
MyTimeSpan.TotalHours//double

formating Strings(sc-asp_019)
==========================================================
Concenate Strings
+ +=

String.Format("Hello {0}. you are from{1}", "BET", "Belize");

Format Numbers
String.Format("Reference Code: {0:000_000-0}", 1234567);
123_456-7

Formatting Dates
http://is.gd/formattingdates
String.Format("Reference Date: {0:ddd-d,mm, yyyy}", someDate)
tue - 5, 07, 2014

formatting currency
http://is.gd/formattingcurrency
String.Format("Total:{0:c}, totalAmout);

formating Strings(sc-asp_021)
==========================================================
Inexes vs Elements
Accessor vs Stored values
Indexes are Zero based

Declaring Arrays
string[] myArray = new string[3];

Declaring and Initializing Arrays
string[] myArray = new string[3]{"moe","larry","curly"};

Setting/ Getting values
string mystring = myArray[1];//Retrieve the second element
myArray[0] = myString// Sets first element

formating Strings(sc-asp_022)
==========================================================
Same as single dimensioal... just requires
more indexes(in dimensions) to get to the element.

double[,] myArray = new double[2,3]

formating Strings(sc-asp_023)
==========================================================
Arrays are imutable = cannot be changed in memory
HOWEVER. .NET   Framework providers helper methods to 
resize an array ... creates a new array and cpies
the old values into it.

Array.Resize (ref myArray, myArray.Length +1);

//Get the highest index;
int highestIndex = myArray.GetUppperBound(0);
// 0 = dimension we want to retrieve the
//upper boundary for

//Arrays have other helper methods
myArray.Sum()
myArray.Min()
myArray.Max()
myArray.Average()


Array.Short(myArray)
Array.Reverse(myArray)

formating Strings(sc-asp_026)
==========================================================

snippet: for TAB TAB on keyboard to get the for loop structure

for(in i; i < 10;i++)
{
//your code
}
i any variable name

1st - counter declaration, can be initialized to any number
2nd - condition, can be any expression taht equates to a bool
3rd- increament i++/ decreament i--, can step more than 1 using +=,

sting[] names = new string[]{"wolverine", "cyclops", "professor x"};

for(int 1 =0; i<names.Length;i++)
{
  //can search for a specific value
  if(names[i] == "professor x")
  {
  //do something
  can break out of additional iterations.
  break;
  }
}



looping with the wile and do while Iteration Statements(sc-asp_027)
==========================================================
Random Random = new Random();
// random.Next(lowerBounds, upperBounds)
random.Next(1, 100);// returns a value between 1 - 100

if some Expression is already false, this will never execute
while(someExpession)
{
//code that would affect whether
//someExpression is true or false
}
//if some Expression is already false, the will run least once
do{
// code goes here..

}

Creating overloaded methods(sc-asp_031)
==================================================
different Method signature, but sam basic function.
Method signature... the number and type of parameters
can have different returne types.


Creating optional parameters (CS_ASP_032)
=================================================
Optioal parameters provided default values when you define
the method, so if you dont supply a value, the default 
will be used.

private void my myMethod(string myRequiredParam, 
                        int myOptioalParam = 1,
                        int myOtherOptionalParam)
                        

Passing Named Arguments into input parameters(CS-ASP_033) 
=======================================================
Allow us to send in parameter arguments out of order!
we just previx the input parameter argument with the  name
of the parameter we're passing in , a colon, then the value:

myMethod(myOtherOptionalParam:500,
myRequireParam: "Hello Required param",
myOptioalParam: 100);

//you still have to pass in required parameters

Creating methods with ouput parameters - (CS-ASP_034)
=============================================================
Allows you to return a value the normal way AND
return a value via a method parameter:

private bool myMethod(string myRequiredParam,
out int myOptionalParam){}

int myValue = );
if(myMethod("Some required"))

Manipulating String (CS-ASP_035)
--------------------------------------
// escaping double quotes
String myString = "This is a double quote: \".";

//accessing  a specific char:
myString[2]

//StartsWith(), Endswith(), Contains()
//check to see if a given string has a set of
//characters beginng, end or somewhere inside.
//Return true/false

//IndexOf()
//Find the index for one string has a set of
//another string.
int myIndex = myString.IndexOf("howdy");

Index(), Remove()
//Insert adds characters starting at a given index
//Remove remves characters starting at a given
//index, and all the way through the length you
//input.
//Substring()
//Retrieve characters beginning at a given index
//all thr way through the length you input.

//Trim(), TrimStart(), TrimEnd()
//Remove space characters both, or just the start
//or the end of the string.

//PadLeft(),PadRight()
//Allow you to specify a length for a string
//and a character to pad the string with if its
//length is less than the specified length.
myString = someValue.PadLeft(10, '#');

//Notice that we'reinputting a chr, not a string
//therefore we have to use a single quote not
//a double quote.

//ToUpper(), ToLower()
//Important! Compare two strings regardless of 
//the case, beacuse in C#, Two strings with
//different cases are Not equal.

//Replace()
Replace every occurance of on string with
//come other string.
myString.Replace("$$$", myValue)

//Split()
//Take a string and split it into may strings
//and store them in a string array
string[] names = myString.Split(';');

//Concatenating strings, immutablility
//StringBuilder - memory efficient way of concatenation strings

Instroduction to classes and Objects (CS-ASP_036)
======================================================
Class is acode block that defines a date type.
An Object is an instance of a Class
Metaphors:
Blueprint vs Houses
Recipe vs cupcakes
Pattern







