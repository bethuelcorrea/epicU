using System;

namespace MyApplication
{
  class Person
  {
    private string name;  // field is private and hidden
    private int age;      // field
    
    public string Name    // property
    {
      get { return name; }
      set { name = value; }
    } 
    
    public int Age // Propery
    {
    	get { return age; }
      	set { age = value; }
    }
    
  }
}