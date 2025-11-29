// Aggregation: A “has-a” relationship where one class contains another but does not own its lifecycle

using _03_Aggregation.Models;

var student1 = new Student("John");
var student2 = new Student("Kim");

var university = new University();

university.AddStudent(student1);
university.AddStudent(student2);

Console.WriteLine($"[{string.Join(", ", university.Students)}]");