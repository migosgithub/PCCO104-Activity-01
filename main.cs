using System;

class Program {
  public static void Main (string[] args) 
  {
    string firstName = "Cyrus";
    string lastName = "Salvador";
    int age = 19;
    string subject = "Intermediate Programming";
    string teacher = "Sir Ralph Lee";
    Console.WriteLine($"Hello World {firstName} {lastName} Age: {age}");
    Console.WriteLine("Hello World " + firstName + " " + lastName + " " + age + " Teacher: " + teacher + " - " + subject);
  }
}