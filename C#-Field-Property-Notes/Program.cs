using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Person myObj = new Person();
      myObj.Name = "Liam";
      Console.WriteLine(myObj.Name);
      
      Person dav = new Person();
      dav.Age = 41;
      Console.WriteLine(dav.Age);
      
    }
  }
}