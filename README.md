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


Arithemetic  Operators (cs-asp-009)
= Not equality, its assignment

math Operators: +-*/

addition assignment
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

c# syntex (cs-asp_010)

operands- variable names, object/server control names, literals - "nouns" (you name these)

operators -"verbs...they act on the operands.

htpp://is.gd/operators

Expressions one or more operands and zero or more operators
that evaluate to a single value

http://is.gd/expressions

statements a complete instruction - assigment of an 
expression.








