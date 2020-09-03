using System;

namespace zzzzzzzzzz
{
  class Program
  {
    static void Main(string[] args)
    {
      Person p = new Person("Tony", "Allen", 32, Person.Genders.Male);
      Console.WriteLine(p.ToString());
    }
     struct Person
    {
      public string firstName;
      public enum Genders : int { Male, Female };
      public string lastName;
      public int age;
      public Genders gender;
      public Person(string _firstName, string _lastName, int _age, Genders _gender)
      {
        firstName = _firstName;
        lastName = _lastName; age = _age;
        gender = _gender;
      }
      public override string ToString()
      {
        return firstName + " " + lastName + " (" + gender + "), age " + age;
      }
    }
  }
  }
