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
Recipe vs Cupcakes
Pattern vs Bluejeans
Cookie vs. Cookes

Classes have members, like properties and Methods.
an instance of the class/ represent the "state"
of the object.  You can set (assign)and get
(retrieve) properties values on an object

Methods define action an instance of a class
can perform, usually on the object instance itself.

You can create an instance of a class using the 
new keyword. Think: "factroy".

You can access the members of an object by using
the member access operator, the dot (.)

Conceptually, classes are dleegated a responsibility
in the system or represent some domain concept
in the system.

Classes are ultimately custom data types, more complex
than the simple data types we ve wrked with.
Therefore you can use them anywhere you use other
data types (like as input parameters opr return
values from a method.)

class Car{

}
Auto Implemented Properties - simple properties
prop tab tab enter enter

this keyword -Access a member of the current instance 
of the class.

public void MyMethod()
{
this.Year = 1976l;
}

Creating Class Files, Creating cohesive Classes and Code Navigation(cs-ASP_037)
==================================
prefer more classes w/ narrowly defined responsibilities
prefer to pu each class in its own file
Prefer high cohession - similarity / sigleness of purpose of the class members
To achieve high cohesion, a rule of thub:try to make your classes fit on
one screen of your IDE(no scorlling required)

understanding Object Refarences and Object Lifetim(cs-ASP_038)
An object reference variable holds a reference to an instantied object
in the computers memory.

MyClass myObject;

The new keyword creates an instance of the class and returns the address of 
object in memory to the refernce variable.

//myObject = new MyClass();
mor than one object reference variable can hold an address to the object in memory.

MyClass myOtherObjectReference = myObject;
Each time a new reference is added, the reference count increases by one. each time
an object refererence variable goes out of scope or is set to null, the reference
count decreases by one

if the reference count is zero, the .NET Framework Run

Understanding the .NET Framework and Compilation(CS-ASP_039)
the .NET Framework consists of:

-Runtime(Common Language Runtime, CLR) :"protective bubble", manages memory,
protects the users machine, etc.

.Net Framework Class Library(fcl, Base Class Library, BCL) thousands
of classes built by Microsoft for every imaginable purpose.

Compilers (C# compiler, VB compiler)- turns your human readable source code into 
(.exe executable, or .dll - class library)

many other tools and features

Initial compilation to intermediate language, then a secon compilation
just in time comilation an optimized version of the assembly for the.

Understanding Namespaces and the using Directive (CS - ASP_040)
============================================================
Namespaces disambiguate class names inside of class libraries or applications

you must reference class names by their full name:

System.Text.Stringbuilder sb = new System.Text.StrinBuilder();
...or, you can employ a using directive at the top the code file to
instruct the compiler to look in those namespaces to find the class that is refernced.

using System.Text
StringBuilder sb = new StringBuilder();

you must alwasys do this if the code youre writing is outside of
the namespace of the class you want to use, even if its in the same
project.

Default namespace defined in project properties (right-clicking on
project name in Solution Explorer, select Properites...)

Creating class Libraries and Adding Reference to Assemblies (CS-ASP-041)
===========================================================
Class Library project - creates a .dll that can be feferenced in other projects

add a reference - the FCL is split into tiny piece, and you must reference
the assemblies that contain the parts of the library you want to use.

Right clic kprojects Reference node in Solution Explorer, select Add Reference

Accessibility Modifiers, Fields and Properties(CS-ASP_042)
====================================================
http://v.gd/access
Public-Class or member can be accessed by any code
Private-Class or member can only be accessed by parent class
Protected-Class or member can only be accessed by parent class or derived class
Internal-Class or member can only be accessed by code inside the same assembly

Classes are internal by default
Methods and properties are private by default

Encapsulation- Hiding implementation behind public interfaces, reduces coupling
increases plug-ability / resuability, maintainability, etc.

private fields have two purposes:
(1) reference to object or variable that used for internal implementation of class
(2)hold the state of an object, backing field for public property

propfull TAB TAB

private int myField;
property int MYProperty
{
 get{return myField;}
 set{if (value>100)
 myField = value;
 else
 //tell the caller that they cant do this
 }
 }
 Full property definition and private fields to control
 access to private fields / state of the object.
 
 propg TAB TAB
 
 public in MyProperty{get; private set;}
 Restricts setting of property to just the class internal implementation
 }
 
 Creating Contructor Methods (CS-ASP-043)
 Constructor are called at the moment of instantitation.
 Used to put the new instace of the class into a valid state.
 public class Foo
{
 public Foo()
 {
 .....
 }
}
Whether you difine it or not, theres a default constructor.
You can override the default (no input parameters)or 
overload the constructor to allow the user to set the 
new instace to a valid state.

Nameing Conventions for Identifiers(CS-ASP_044)
pascalCase - public
camelCase- private , protected

public classes, methods and properties - PascalCase
Private helper methods, input parameters -camelCase
locally scoped variables- camelCase
Private field - camelCase prefixed s/ underscore:_firstName

Choose long, memorable, understandable names
that convey meaning / intent.

Static versus Instance Members(CS-ASP_045)
=======================================
Static members - no instance of the class required to call method

Instance member - must create an instance w new keyword to call methods and properties

Can mix both in the same class, but conat reference instance
members from inside of static members.

Classes can be decaoted w/ staic keyword... all members must be static, cant creat a new instance of that class

System.Math
http://v.gd/static

Working with the list Collection(CS-ASP-046)
+++++++++++++++++++++++++++++++++++++++++++++++++
use Generic Collection to work with items in a strongly typed fashion.

Better that arrays;
Know the type of the item for a certainty, no castion / coverting
Better performance inserting/ removing / updating
Colllections provide more flexivle otions to access items in the collection
Allows for LINQ extension methods

many diffeent collection - specialties

"Beneric Collections"
list<T>
Dictionsary<Tkey, Tvalue>
T=> data type you need
"you make a generic specific by providing a data type."

List<string> only sotre strings (strong typed)
List<Car> - only store Cars in that collection

//Assume I have three objects: car1, car2, car3
List<Car> cars = new ist<Car>():
cars.add(car1);
cars.add(car2);
cars.add(car3);

Int numberOfCars = cars.Count;
Car myCar = cars.ElementAt(1); Return 2nd car in the collection
//Terminoloty: you access a member of a collection

object Initializer(Cs-ASP_047)
++++++++++++++++++++++++++++++++++++++
concise way to initialize a new object(or collection)with values.

//Didnt talk about this form:

Collection Initializer(CS-ASP-048)
=================================
Shirt cut to creat newinstance of a generic collection and 
initialized it by immendiately adding new instance of a given type.

list<Car>

working with the Dictionary<Tkey, TValue> collection(cs-ASP_049)
Dictionary allows you to use a key to access amember of the collection
Think: webster's dictionay... the word(key), then the definition (instance of a given type)
key is anything meaningful in your system.
Key must be unique.

Tkey =>type of the key
Tvalue= type of the value

Dictionary<string, Car> cars = new Dictionary<string, Car>();
cars.Add("v123", new Car{Make="bmw", Model="mazda"});

cars.ElementAt(1).Key //
cars.ElementAt(1).Value//return the car object in the 2nd position

//Beter way to access Dictionary...
Car v2;
if(cars.TryGetValue("v234", out v2))
{
retult +=v2.Year;
}
//Remove
if (cars.Remove(v345))
{
resi;t +="Successfully removed car";
}

Looping with the foreach Iteration statement(CS-ASP_050)
===============================================
More elegant way of iteration through collection.
code snippet: froeach TAB TAB
foreach (Car car in cars)
{
result +=car.Make;
}

Implictyly typed local Variables with the var keyword(CS-ASP_051)
============================================================
(Applies to locally scoped variable declarations)
Compiler is smart enough to figure out the data type when you initialize the variable.
Becomes increasingly important because sometimes its difficult to know what the dat type
is supposed to be (LINQ)
int hitPoints = 0;
...is the equivalent of ...
var hitPoints = 0;

string heroName = "Pentagorn";
...is the equivalent of .....
var heroName ="Pentagorn"

var cars = new List<Car>()
{
...
}
Rules
1. Must initialize the variable
2. Variable is permaenty set to the implicti dat type.
3. Cant be used for a public property/ variable

















