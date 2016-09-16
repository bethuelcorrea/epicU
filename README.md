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








